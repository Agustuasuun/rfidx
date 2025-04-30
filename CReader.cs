using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace Demo
{
    class CReader
    {
        IntPtr HIDHandle;
        int HIDAddress;

        public CReader()//模块初始化
        {

            HIDHandle = IntPtr.Zero;
            HIDAddress = 0;
        }

        public IntPtr GetHIDHandle()
        {
            return HIDHandle;
        }

        ////////////////////HID Device API Start ///////////////////////////////////////
        /////////////////////////////////////
        /////////////////////////////////////

        [DllImport("HIDdll.dll", EntryPoint = "API_USBGetConnectedDeviceNum")]
        static extern int API_USBGetConnectedDeviceNum();
        public int GetHIDDevice(ref int device_num)
        {
            device_num = API_USBGetConnectedDeviceNum();
            if (device_num > 0)
                return 0;//有设备
            else
                return -1;//没有设备
        }

        [DllImport("HIDdll.dll", EntryPoint = "API_USBOpenWithNum")]
        static extern int API_USBOpenWithNum(ref IntPtr HIDHandle, int DeviceIndex, short NumInputBuffers);
        public int OpenHIDDevice(int DeviceIndex)
        {
            int status = API_USBOpenWithNum(ref HIDHandle, DeviceIndex, 0x40);
            if (status == 0)
            {
                return 0;//成功
            }
            else if (status == 1)
            {
                return -1;//没有找到设备
            }
            else
            {
                return -2;//未知错误
            }
        }

        [DllImport("HIDdll.dll", EntryPoint = "API_USBCloseComm")]
        static extern bool API_USBCloseComm(IntPtr HidPortHandle);
        public int CloseHIDPort()
        {
            if (IntPtr.Zero != HIDHandle)
            {
                bool status = API_USBCloseComm(HIDHandle);
                if (status)
                {
                    HIDHandle = IntPtr.Zero;
                    return 0;//操作成功
                }
                else
                {
                    return -2;///关闭不成功
                }
            }
            else
            {
                return -1;//前一次设备打开不成功
            }
        }

        [DllImport("HIDdll.dll", EntryPoint = "API_USBGetSerNum")]
        static extern int API_USBGetSerNum(IntPtr HIDHandle, int DeviceAddress, ref byte buf);
        public int GetHIDSerNum(int DeviceAddress, ref byte buf)
        {
            if (IntPtr.Zero == HIDHandle)
                return -1;
            HIDAddress = DeviceAddress;//保存地址
            return API_USBGetSerNum(HIDHandle, DeviceAddress, ref buf);
        }

        [DllImport("HIDdll.dll", EntryPoint = "API_SetDeviceAddress")]
        static extern int API_SetDeviceAddress(IntPtr HIDHandle, int DeviceAddress, int NewAddress, ref byte buf);
        public int SetHIDAddress(int NewAddress, ref byte buf)
        {
            if (HIDHandle != IntPtr.Zero)
            {
                if (NewAddress != HIDAddress)
                {
                    int ret = API_SetDeviceAddress(HIDHandle, HIDAddress, NewAddress, ref buf);
                    if (ret == 0)
                    {
                        HIDAddress = NewAddress;
                        return 0;
                    }
                    else
                    {
                        return ret;
                    }
                }
                else
                {
                    return -2;//设备地址没有更换
                }
            }
            else
            {
                return -1;//没有打开设备
            }
        }

        [DllImport("HIDdll.dll", EntryPoint = "API_USBControlLED")]
        static extern int API_USBControlLED(IntPtr HIDHandle, int DeviceAddress, byte led_time, byte led_num, ref byte buf);
        public int SetHIDLED(byte led_time, byte led_num, ref byte buf)
        {
            if (HIDHandle != IntPtr.Zero)
            {
                if (led_time < 0 || led_time > 0x32)
                {
                    return -2;//超出了led亮的范围，大于的话只会亮一次
                }

                return API_USBControlLED(HIDHandle, HIDAddress, led_time, led_num, ref buf);
            }
            else
            {
                return -1;//打开了设备
            }
        }
        [DllImport("HIDdll.dll", EntryPoint = "API_USBControlBuzzer")]
        static extern int API_USBControlBuzzer(IntPtr HIDHandle, int DeviceAddress, byte buzzer_time, byte buzzer_num, ref byte buf);
        public int SetHIDBuzzer(byte buzzer_time, byte buzzer_num, ref byte buf)
        {
            if (HIDHandle != IntPtr.Zero)
            {
                if (buzzer_time < 0 || buzzer_time > 0x32)
                {
                    return -2;//超出了led亮的范围，大于的话只会亮一次
                }

                return API_USBControlBuzzer(HIDHandle, HIDAddress, buzzer_time, buzzer_num, ref buf);
            }
            else
            {
                return -1;//没有打开设备
            }
        }

        [DllImport("HIDdll.dll", EntryPoint = "API_USBMF_Request")]
        static extern int API_USBMF_Request(IntPtr HIDHandle, int HIDAddress, byte mode, ref byte buf);
        public int HID_Request_14443A(byte mode, ref byte buf)
        {
            if (HIDHandle != IntPtr.Zero)
            {
                return API_USBMF_Request(HIDHandle, HIDAddress, mode, ref buf);
            }
            else
            {
                return -1;
            }
        }

        [DllImport("HIDdll.dll", EntryPoint = "API_USBMF_Anticoll")]
        static extern int API_USBMF_Anticoll(IntPtr HIDHandle, int HIDAddress, ref byte flag, ref byte buf);
        public int HID_Anticoll_14443A(ref byte flag, ref byte buf)
        {
            if (HIDHandle != IntPtr.Zero)
            {
                return API_USBMF_Anticoll(HIDHandle, HIDAddress, ref flag, ref buf);
            }
            else
            {
                return -1;
            }
        }

        [DllImport("HIDdll.dll", EntryPoint = "API_USBMF_Select")]
        static extern int API_USBMF_Select(IntPtr HIDHandle, int HIDAddress, ref byte uid, byte len, ref byte buf);
        public int HID_Select_14443A(ref byte uid, byte len, ref byte buf)
        {
            if (HIDHandle != IntPtr.Zero)
            {
                return API_USBMF_Select(HIDHandle, HIDAddress, ref uid, len, ref buf);
            }
            else
            {
                return -1;
            }
        }

        [DllImport("HIDdll.dll", EntryPoint = "API_USBMF_Halt")]
        static extern int API_USBMF_Select(IntPtr HIDHandle, int HIDAddress);
        public int HID_Halt_14443A()
        {
            if (HIDHandle != IntPtr.Zero)
            {
                return API_USBMF_Select(HIDHandle, HIDAddress);
            }
            else
            {
                return -1;
            }
        }

        [DllImport("HIDdll.dll", EntryPoint = "API_USBMF_GET_SNR")]
        static extern int API_USBMF_GET_SNR(IntPtr HIDHandle, int HIDAddress, byte mode, byte halt, ref byte flag, ref byte buf);
        public int HID_GetSerialNum_14443A(byte mode, byte halt, ref byte flag, ref byte buf)
        {
            if (HIDHandle != IntPtr.Zero)
            {
                return API_USBMF_GET_SNR(HIDHandle, HIDAddress, mode, halt, ref flag, ref buf);
            }
            else
            {
                return -1;
            }
        }

        [DllImport("HIDdll.dll", EntryPoint = "API_USBMF_Read")]
        static extern int API_USBMF_Read(IntPtr HIDHandle, int HIDAddress, byte mode, byte blockaddress, byte blocknum, ref byte key, ref byte buf);
        public int HID_Read_14443A(byte mode, byte blockaddress, byte blocknum, ref byte key, ref byte buf)
        {
            if (HIDHandle != IntPtr.Zero)
            {
                return API_USBMF_Read(HIDHandle, HIDAddress, mode, blockaddress, blocknum, ref key, ref buf);
            }
            else
            {
                return -1;
            }
        }

        [DllImport("HIDdll.dll", EntryPoint = "API_USBUL_ReadPage")]
        static extern int API_USBUL_ReadPage(IntPtr HIDHandle, int HIDAddress, byte mode, byte blocknum, byte blockaddress, ref byte buf);
        public int HID_Read_Ultralight(byte mode, byte blocknum, byte blockaddress, ref byte buf)
        {
            if (HIDHandle != IntPtr.Zero)
            {
                return API_USBUL_ReadPage(HIDHandle, HIDAddress, mode, blocknum, blockaddress, ref buf);
            }
            else
            {
                return -1;
            }
        }

        [DllImport("HIDdll.dll", EntryPoint = "API_USBMF_Write")]
        static extern int API_USBMF_Write(IntPtr HIDHandle, int HIDAddress, byte mode, byte blockaddress, byte blocknum, ref byte key, ref byte text, ref byte buf);
        public int HID_Write_14443A(byte mode, byte blockaddress, byte blocknum, ref byte key, ref byte text, ref byte buf)
        {
            if (HIDHandle != IntPtr.Zero)
            {
                return API_USBMF_Write(HIDHandle, HIDAddress, mode, blockaddress, blocknum, ref key, ref text, ref buf);
            }
            else
            {
                return -1;
            }
        }

        [DllImport("HIDdll.dll", EntryPoint = "API_USBUL_WritePage")]
        static extern int API_USBUL_WritePage(IntPtr HIDHandle, int HIDAddress, byte mode, byte blocknum, byte blockaddress, ref byte buf);
        public int HID_Write_Ultralight(byte mode, byte blocknum, byte blockaddress, ref byte buf)
        {
            if (HIDHandle != IntPtr.Zero)
            {
                return API_USBUL_WritePage(HIDHandle, HIDAddress, mode, blocknum, blockaddress, ref buf);
            }
            else
            {
                return -1;
            }
        }

        [DllImport("HIDdll.dll", EntryPoint = "API_USBMF_InitVal")]
        static extern int API_USBMF_InitVal(IntPtr HIDHandle, int HIDAddress, byte mode, byte sector, ref byte key, int EP_value, ref byte buf);
        public int HID_InitEP_14443A(byte mode, byte sector, ref byte key, int EP_value, ref byte buf)
        {
            if (HIDHandle != IntPtr.Zero)
            {
                return API_USBMF_InitVal(HIDHandle, HIDAddress, mode, sector, ref  key, EP_value, ref  buf);
            }
            else
            {
                return -1;
            }
        }

        [DllImport("HIDdll.dll", EntryPoint = "API_USBMF_Inc")]
        static extern int API_USBMF_Inc(IntPtr HIDHandle, int HIDAddress, byte mode, byte sector, ref byte key, ref int EP_value, ref byte buf);
        public int HID_IncreaseEP_14443A(byte mode, byte sector, ref byte key, ref int EP_value, ref byte buf)
        {
            if (HIDHandle != IntPtr.Zero)
            {
                return API_USBMF_Inc(HIDHandle, HIDAddress, mode, sector, ref  key, ref EP_value, ref  buf);
            }
            else
            {
                return -1;
            }
        }

        [DllImport("HIDdll.dll", EntryPoint = "API_USBMF_Dec")]
        static extern int API_USBMF_Dec(IntPtr HIDHandle, int HIDAddress, byte mode, byte sector, ref byte key, ref int EP_value, ref byte buf);
        public int HID_DecreaseEP_14443A(byte mode, byte sector, ref byte key, ref int EP_value, ref byte buf)
        {
            if (HIDHandle != IntPtr.Zero)
            {
                return API_USBMF_Dec(HIDHandle, HIDAddress, mode, sector, ref  key, ref EP_value, ref  buf);
            }
            else
            {
                return -1;
            }
        }

        [DllImport("HIDdll.dll", EntryPoint = "API_USBMF_TransferCMD")]
        static extern int API_USBMF_TransferCMD(IntPtr HIDHandle, int HIDAddress, byte crc, ref byte cmd, ref byte lenght, ref byte buf);
        public int HID_TFCMD_14443A(byte crc, ref byte cmd, ref byte length, ref byte buf)
        {
            if (HIDHandle != IntPtr.Zero)
            {
                return API_USBMF_TransferCMD(HIDHandle, HIDAddress, crc, ref  cmd, ref length, ref  buf);
            }
            else
            {
                return -1;
            }
        }

        /////////////////////HID API End/////////////////////////////
        /////////////////////////////////////
    }
}
