using Demo.Extensions;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Demo
{
    public partial class dlgDemo : Form
    {
        private CReader _reader = new CReader();
        private System.Threading.Timer _timer;
        private string _previousSerialNumber = string.Empty;
        AboutWindow _aboutWindow = new AboutWindow();

        public dlgDemo()
        {
            InitializeComponent();
        }

        //private System.Timers.Timer timerClock = new System.Timers.Timer();   

        private void dlgDemo_Load(object sender, EventArgs e)
        {
            var aa = DateTime.UtcNow;

            //trial mode
            if (DateTime.UtcNow > Properties.Settings.Default.LicenseExpired.ToUniversalTime())
            {
                MessageBox.Show("License expired!.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Application.Exit();
            }

            int i;
            string strTmp;


            //////////////Set Parameter tab page////////////////////////
            //////组合框初始地址
            for (i = 0; i < 0xff + 1; i++)
            {
                strTmp = string.Format("{0:X2}", i);
                cob_sp_address.Items.Add(strTmp);
                addressComboBox.Items.Add(strTmp);
            }
            cob_sp_address.SelectedIndex = 0;
            addressComboBox.SelectedIndex = 0;
            ////设置LED 初始值
            tb_sp_led_time.Text = "0X18";
            tb_sp_led_num.Text = "0X0A";
            /////设置Buzzer初始值
            tb_sp_buzzer_time.Text = "0X18";
            tb_sp_buzzer_num.Text = "0X0A";

            /////////////////14443A tab page Start/////////////////////////

            ////////Get  mode的初始化
            cob14443A_mode_get.Items.Insert(0, "All");
            cob14443A_mode_get.Items.Insert(1, "Idle");
            cob14443A_mode_get.SelectedIndex = 1;
            ///////Halt 的初始化
            cob14443A_halt.Items.Add("None");
            cob14443A_halt.Items.Add("Halt");
            cob14443A_halt.SelectedIndex = 0;

            //Open connection

#if DEBUG

#else
            OpenConnection();
#endif

            _timer = new System.Threading.Timer(OnGetSerialNumberTimerTick, null, 2000, 2000);

            Hide();
        }

        private void btn_setparam_clear_Click(object sender, EventArgs e)
        {
            tb_sp_message.Text = string.Empty;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            byte[] buf = new byte[64];
            byte flag = 2;

            byte mode = (byte)cob14443A_mode_get.SelectedIndex;
            byte halt = (byte)cob14443A_halt.SelectedIndex;

            int ret = _reader.HID_GetSerialNum_14443A(mode, halt, ref flag, ref buf[0]);
            if (ret == 0)
            {
                if (flag == 0)
                {
                    tb_sp_message.AppendText("\r\nThere is only one card !");
                }
                else if (flag == 1)
                {
                    tb_sp_message.AppendText("\r\nThere are multiple cards !");
                }
                else if (flag == 2)
                {
                    tb_sp_message.AppendText("\r\nMaybe the initial flag value is 2 !");
                }
                else
                {
                    tb_sp_message.AppendText("\r\nUnknown reason !");
                }

                byte[] serialNumberBytes = buf.Skip(1).Take(buf[0]).ToArray();

                string serialNumber = serialNumberBytes.ToEncodedString();
                //SendToNotepad(serialNumber);

                tb_sp_message.AppendText("\r\nThe card' serial number is " + serialNumber);
                serialNumberLabel.Text = serialNumber;
            }
            else if (ret == -1)
            {
                tb_sp_message.AppendText("\r\nThe device is not opened !");
            }
            else
            {
                tb_sp_message.AppendText(CPublic.ShowError(ret, ref buf[0]));
            }

        }

        private void btn_setparam_read_Click(object sender, EventArgs e)
        {
            if (IntPtr.Zero != _reader.GetHIDHandle())
            {
                string strTmp = "";
                byte[] buf = new byte[64];

                int deviceAddress = CPublic.HexStringToInt(addressComboBox.Text);
                if (deviceAddress < 0 || deviceAddress > 255)
                {
                    tb_sp_message.AppendText("\r\nDevice address must between 0X00-0XFF !");
                    return;
                }

                int ret = _reader.GetHIDSerNum(deviceAddress, ref buf[0]);
                if (ret == 0)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        strTmp += buf[i + 1].ToString("X2") + " ";
                    }

                    tb_sp_message.AppendText("\r\nVersion is " + strTmp);
                }
                else
                {
                    tb_sp_message.AppendText("\r\nGet version error !");
                    tb_sp_message.AppendText("\r\nAPI error:" + CPublic.ApiError(ret) + "Return error:" + CPublic.ReturnCodeError(ref buf[0]));
                }
            }
            else
            {
                tb_sp_message.AppendText("\r\nThe device is not opened !");
            }
        }

        private void btn_setparam_setaddress_Click(object sender, EventArgs e)
        {
            byte[] buf = new byte[16];
            int NewAddress = CPublic.HexStringToInt(cob_sp_address.Text);
            if (NewAddress < 0 || NewAddress > 255)
            {
                tb_sp_message.AppendText("\r\nDevice address must between 0X00-0XFF !");
            }

            int ret = _reader.SetHIDAddress(NewAddress, ref buf[0]);
            if (ret == 0)
            {
                tb_sp_message.AppendText("\r\nSet Device address success !");
                addressComboBox.SelectedItem = cob_sp_address.Text;
            }
            else if (ret == -1)
            {
                tb_sp_message.AppendText("\r\nThe device is not opened !");
            }
            else if (ret == -2)
            {
                tb_sp_message.AppendText("\r\nDeviceAddress need change !");
            }
            else
            {
                tb_sp_message.AppendText("\r\nSet Device address error !");
                //tb_sp_message.Text += "\r\n API error:" + CPublic.ApiError(ret) +"Return error:" + CPublic.ReturnCodeError(ref buf[0]);
                tb_sp_message.AppendText(CPublic.ShowError(ret, ref buf[0]));
            }

        }

        private void btn_sp_led_set_Click(object sender, EventArgs e)
        {
            byte[] buf = new byte[16];
            byte led_time = (byte)CPublic.HexStringToInt(tb_sp_led_time.Text);
            byte led_num = (byte)CPublic.HexStringToInt(tb_sp_led_num.Text);

            int ret = _reader.SetHIDLED(led_time, led_num, ref buf[0]);
            if (ret == 0)
            {
                tb_sp_message.AppendText("\r\nSet LED success !");
            }
            else if (ret == -1)
            {
                tb_sp_message.AppendText("\r\nThe device is not opened !");
            }
            else if (ret == -2)
            {
                tb_sp_message.AppendText("\r\nLed time Param need between 0X00-0X32 !");
            }
            else
            {
                tb_sp_message.AppendText(CPublic.ShowError(ret, ref buf[0]));
            }
        }

        private void btn_sp_buzzer_set_Click(object sender, EventArgs e)
        {
            byte[] buf = new byte[16];
            byte buzzer_time = (byte)CPublic.HexStringToInt(tb_sp_buzzer_time.Text);
            byte buzzer_num = (byte)CPublic.HexStringToInt(tb_sp_buzzer_num.Text);

            int ret = _reader.SetHIDBuzzer(buzzer_time, buzzer_num, ref buf[0]);
            if (ret == 0)
            {
                tb_sp_message.AppendText("\r\nSet Buzzer success !");
            }
            else if (ret == -1)
            {
                tb_sp_message.AppendText("\r\nThe device is not opened !");
            }
            else if (ret == -2)
            {
                tb_sp_message.AppendText("\r\nBuzzer time Param need between 0X00-0X32 !");
            }
            else
            {
                tb_sp_message.AppendText(CPublic.ShowError(ret, ref buf[0]));
            }
        }

        private void tb_sp_message_TextChanged(object sender, EventArgs e)
        {
            tb_sp_message.SelectionStart = tb_sp_message.Text.Length;

            tb_sp_message.ScrollToCaret();
        }
        private void dlgDemo_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseConnection();
        }
        private void serialNumberLabel_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(serialNumberLabel.Text))
            {
                copySnButton.Enabled = true;
            }
            else
            {
                copySnButton.Enabled = false;
            }
        }

        private void copySnButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(serialNumberLabel.Text))
            {
                Clipboard.SetText(serialNumberLabel.Text);
            }
        }

        #region Private methods
        private void OpenConnection()
        {
            int device_num = 0;

            int ret = _reader.GetHIDDevice(ref device_num);
            if (ret == 0)
            {
                ret = _reader.OpenHIDDevice(device_num - 1);
                if (ret != 0)
                {
                    MessageBox.Show("Failed to open connection, make sure the device connected correctly!.",
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Application.Exit();
                }
            }
            else
            {
                MessageBox.Show("Device not exist!, please connect the device and reopen the app.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Application.Exit();
            }
        }
        private void CloseConnection()
        {
            _reader.CloseHIDPort();
        }
        private void SendToNotepad(string text)
        {
            string fileName = Path.GetTempFileName();
            File.WriteAllText(fileName, text);
            Process.Start("notepad.exe", fileName);
        }
        private string GetCardSerialNumber()
        {
            byte[] buf = new byte[64];
            byte flag = 2;

            byte mode = (byte)cob14443A_mode_get.SelectedIndex;
            byte halt = (byte)cob14443A_halt.SelectedIndex;

            int ret = _reader.HID_GetSerialNum_14443A(mode, halt, ref flag, ref buf[0]);
            if (ret == 0)
            {
                byte[] serialNumberBytes = buf.Skip(1).Take(buf[0]).ToArray();
                return serialNumberBytes.ToEncodedString();
            }
            else
            {
                return string.Empty;
            }
        }
        #endregion Private methods

        #region Event handlers
        private void OnGetSerialNumberTimerTick(object sender)
        {
#if DEBUG
            SendSerialNumber("Test");
#else
            SendSerialNumber(GetCardSerialNumber());
#endif
        }
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _aboutWindow.ShowDialog();
        }

        private void SendSerialNumber(string serialNumber)
        {
            bool isFocused = (bool)Invoke((Func<bool>)(() => !IsDisposed && ActiveForm != null));
            if (!isFocused && !string.IsNullOrWhiteSpace(serialNumber))
            {
                SendKeys.SendWait($"{serialNumber} \n");
            }
        }
        #endregion Event handlers
    }
}