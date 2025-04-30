using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    class CPublic
    {
        static int m_languageFlag = 1;//语言选择
        
        ////////////去掉字符中非16进制的字符/////////////////
        public static string StrToHexStr(string str)            
        {
            string strTmp = "";
	        int i,len;
            len = str.Length;
            
            for (i = 0; i < len; i++)
            {
                if ((str[i] >= 'a' && str[i] <= 'f') || 
                    (str[i] >= 'A' && str[i] <= 'F') || 
                    (str[i] >= '0' && str[i] <= '9') || 
                    str[i] == 0)
                {
                    strTmp += (char)str[i];
                }
            }
            return strTmp;/////为什么总是这样进行返回值传送
        }

        
        //////////// 十六进制的字符串转换为16进制的数字/////////////////
        public static int HexStringToInt(string hexStr)
        {
            string strTmp = StrDelete0X(hexStr);
            int iOutput = int.Parse(strTmp, System.Globalization.NumberStyles.HexNumber);
            return iOutput;
        }
        
        
        /////////// 去除字符串中的字符”0“ ”X“ 或 ”x“，变为纯粹的数字字符串////////
        
        public static string StrDelete0X(string str)
        {
            string strTmp = "";
            byte[] byteTmp = new byte[16];

            if ('0' == str[0] && ('x' == str[1] || 'X' == str[1]))
            {
                strTmp += (char)str[2];
                strTmp += (char)str[3];
            }
            else
            {
                strTmp = str;
            }
            return strTmp;
        }

       
        /// 把字符串转换为16进制字符串，然后循环按两个16进制数字转换为数字放到数组中 
        public static byte[] CharToByte(string str)
        {
            string strTmp;
            strTmp = StrToHexStr(str);
            str = strTmp;
            strTmp = "";
            byte []tmpByte = new byte[1024];
	       
            for(int i = 0;i < str.Length;i += 2)
	        {
                strTmp += str[i];
                if (i + 1 < str.Length)
                {
                    strTmp += str[i + 1];
                }
		        tmpByte[i / 2] = (byte)HexStringToInt(strTmp);
                strTmp = "";
	        }
            return tmpByte;
        }

        public static string ShowError(int Apierror, ref byte returnerror)
        {
            string strTmp = "\r\nAPI error:" + ApiError(Apierror) + "Return error:" + ReturnCodeError(ref returnerror);
            strTmp += "\r\n";
            return strTmp;
        }

        
        /////////////// 操作返回值函数/////////////////
        public static string ApiError(int apiReturn)
        {
            string str = "";

            if(m_languageFlag == 0)
            {
                switch(apiReturn)
                {
                case 0x00:
                    str = "Successfully\r\n";
                    break;
                case 0x01:
                    str = "Error\r\n";
	                break;
                case 0x02:
                    str = "Unmatched length of receiving data\r\n";
	                break;
                case 0x03:
                    str = "Failure sending of COM\r\n";
                    break;
                case 0x04:
                    str = "Nothing receiving from COM\r\n";
                    break;
                case 0x05:
                    str = "Unmatched address of equipment\r\n";
                    break;
                case 0x07:
                    str = "Failure checksum\r\n";
                    break;
                case 0x0A:
                    str = "Failure input parameters\r\n";
                    break;
                default:
                    str = "Not defined error\r\n";
                	break;
                }
            }
            else
            {
                switch(apiReturn)
                {
                case 0x00:
                    str = "命令执行成功\r\n";
                    break;
                case 0x01:
                    str = "命令操作失败\r\n";
	                break;
                case 0x02:
                    str = "接收数据长度不匹配\r\n";
	                break;
                case 0x03:
                    str = "串口发送失败\r\n";
                    break;
                case 0x04:
                    str = "串口未接到任何数据\r\n";
                    break;
                case 0x05:
                    str = "表示设备地址不匹配\r\n";
                    break;
                case 0x07:
                    str = "校验和不正确\r\n";
                    break;
                case 0x08:
                    str = "设备没有打开\r\n";
                    break;
                case 0x0A:
                    str = "输入参数有误，请参见不具体的函数说明\r\n";
                    break;
                default:
                    str = "未定义的操作错误\r\n";
                	break;
                }
            }
            return str;
        }

        //////////状态返回值函数/////////////

        //public static string ReturnCodeError( byte buf)//////是否可以不需要进行ref
        public static string ReturnCodeError(ref byte buf)
        {
            string str = "";
            if (m_languageFlag == 0)
            {
                switch (buf)
                {
                    case 0x00:
                        str = "Successfully\r\n";
                        break;
                    case 0x01:
                        str = "Error\r\n";
                        break;
                    case 0x80:
                        str = "Setting successfully\r\n";
                        break;
                    case 0x81:
                        str = "Fail operating\r\n";
                        break;
                    case 0x82:
                        str = "Error,overtime\r\n";
                        break;
                    case 0x83:
                        str = "Error,no card\r\n";
                        break;
                    case 0x84:
                        str = "Error,data of card\r\n";
                        break;
                    case 0x85:
                        str = "Error,Incorrect input parameter or command format\r\n";
                        break;
                    case 0x87:
                        str = "Unknown failure\r\n";
                        break;
                    case 0x89:
                        str = "Error,Incorrect input parameter or command format\r\n";
                        break;
                    case 0x8A:
                        str = "Initial block error\r\n";
                        break;
                    case 0x8B:
                        str = "Wrong card Serial Number in the anti-collision\r\n";
                        break;
                    case 0x8C:
                        str = "Password Authentication failed\r\n";
                        break;
                    case 0x8f:
                        str = "Error,Input command code not exist\r\n";
                        break;
                    case 0x90:
                        str = "The card were unmatched for the command\r\n";
                        break;
                    case 0x91:
                        str = "Error in order format\r\n";
                        break;
                    case 0x92:
                        str = "Unmatched FLAG parameter and OPTION parameter\r\n";
                        break;
                    case 0x93:
                        str = "Inexistent block\r\n";
                        break;
                    case 0x94:
                        str = "Locked,unchangeable operation\r\n";
                        break;
                    case 0x95:
                        str = "Locking operation unsuccessfully\r\n";
                        break;
                    case 0x96:
                        str = "Write operation unsuccessfully\r\n";
                        break;
                    default:
                        str = "Not defined error\r\n";
                        break;
                }
            }
            else
            {
                switch (buf)
                {
                    case 0x00:
                        str = "命令执行成功\r\n";
                        break;
                    case 0x01:
                        str = "命令操作失败（具体说明参见函数）\r\n";
                        break;
                    case 0x80:
                        str = "参数设置成功\r\n";
                        break;
                    case 0x81:
                        str = "参数设置失败\r\n";
                        break;
                    case 0x82:
                        str = "通讯超时\r\n";
                        break;
                    case 0x83:
                        str = "卡不存在\r\n";
                        break;
                    case 0x84:
                        str = "接收卡数据出错\r\n";
                        break;
                    case 0x85:
                        str = "输入参数或者输入命令格式错误\r\n";
                        break;
                    case 0x87:
                        str = "未知的错误\r\n";
                        break;
                    case 0x89:
                        str = "输入参数或者输入命令格式错误\r\n";
                        break;
                    case 0x8A:
                        str = "在块初始化中出现错误\r\n";
                        break;
                    case 0x8B:
                        str = "防冲突过程中得到错误的序列号\r\n";
                        break;
                    case 0x8C:
                        str = "密码认证没有通过\r\n";
                        break;
                    case 0x8f:
                        str = "输入的指令代码不存在\r\n";
                        break;
                    case 0x90:
                        str = "卡不支持这个命令\r\n";
                        break;
                    case 0x91:
                        str = "命令格式有错误\r\n";
                        break;
                    case 0x92:
                        str = "在命令的FLAG参数中，不支持OPTION 模式\r\n";
                        break;
                    case 0x93:
                        str = "要操作的BLOCK不存在\r\n";
                        break;
                    case 0x94:
                        str = "要操作的对象已经别锁定，不能进行修改\r\n";
                        break;
                    case 0x95:
                        str = "锁定操作不成功\r\n";
                        break;
                    case 0x96:
                        str = "写操作不成功\r\n";
                        break;
                    default:
                        str = "未定义的操作错误\r\n";
                        break;
                }
            }
            return str;
        }
    }
}
