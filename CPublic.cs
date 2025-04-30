using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    class CPublic
    {
        static int m_languageFlag = 1; // Pemilihan bahasa (0 = Inggris, 1 = Bahasa Indonesia)

        //////////// Menghapus karakter yang bukan heksadesimal dari string /////////////////
        public static string StrToHexStr(string str)
        {
            string strTmp = "";
            int i, len;
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
            return strTmp; // Selalu mengembalikan nilai string hasil
        }

        //////////// Mengubah string heksadesimal menjadi angka desimal /////////////////
        public static int HexStringToInt(string hexStr)
        {
            string strTmp = StrDelete0X(hexStr);
            int iOutput = int.Parse(strTmp, System.Globalization.NumberStyles.HexNumber);
            return iOutput;
        }

        /////////// Menghapus karakter "0x" atau "0X" dari string, menghasilkan string angka murni ////////
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

        /// Mengubah string menjadi array byte, dengan mengonversi setiap dua karakter hex ke byte
        public static byte[] CharToByte(string str)
        {
            string strTmp;
            strTmp = StrToHexStr(str);
            str = strTmp;
            strTmp = "";
            byte[] tmpByte = new byte[1024];

            for (int i = 0; i < str.Length; i += 2)
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
            string strTmp = "\r\nKesalahan API: " + ApiError(Apierror) + "Kesalahan Balikan: " + ReturnCodeError(ref returnerror);
            strTmp += "\r\n";
            return strTmp;
        }

        /////////////// Fungsi pesan kesalahan API ///////////////////
        public static string ApiError(int apiReturn)
        {
            string str = "";

            if (m_languageFlag == 0) // Bahasa Inggris
            {
                switch (apiReturn)
                {
                    case 0x00: str = "Successfully\r\n"; break;
                    case 0x01: str = "Error\r\n"; break;
                    case 0x02: str = "Unmatched length of receiving data\r\n"; break;
                    case 0x03: str = "Failure sending of COM\r\n"; break;
                    case 0x04: str = "Nothing receiving from COM\r\n"; break;
                    case 0x05: str = "Unmatched address of equipment\r\n"; break;
                    case 0x07: str = "Failure checksum\r\n"; break;
                    case 0x0A: str = "Failure input parameters\r\n"; break;
                    default: str = "Not defined error\r\n"; break;
                }
            }
            else // Bahasa Indonesia
            {
                switch (apiReturn)
                {
                    case 0x00: str = "Perintah berhasil dijalankan\r\n"; break;
                    case 0x01: str = "Gagal menjalankan perintah\r\n"; break;
                    case 0x02: str = "Panjang data yang diterima tidak cocok\r\n"; break;
                    case 0x03: str = "Gagal mengirim lewat port serial\r\n"; break;
                    case 0x04: str = "Tidak menerima data apapun dari port serial\r\n"; break;
                    case 0x05: str = "Alamat perangkat tidak cocok\r\n"; break;
                    case 0x07: str = "Checksum tidak valid\r\n"; break;
                    case 0x08: str = "Perangkat belum dibuka\r\n"; break;
                    case 0x0A: str = "Parameter masukan salah, silakan lihat dokumentasi fungsi\r\n"; break;
                    default: str = "Kesalahan tidak terdefinisi\r\n"; break;
                }
            }
            return str;
        }

        ////////// Fungsi pesan status dari kode pengembalian ////////
        public static string ReturnCodeError(ref byte buf)
        {
            string str = "";
            if (m_languageFlag == 0) // Bahasa Inggris
            {
                switch (buf)
                {
                    case 0x00: str = "Successfully\r\n"; break;
                    case 0x01: str = "Error\r\n"; break;
                    case 0x80: str = "Setting successfully\r\n"; break;
                    case 0x81: str = "Fail operating\r\n"; break;
                    case 0x82: str = "Error,overtime\r\n"; break;
                    case 0x83: str = "Error,no card\r\n"; break;
                    case 0x84: str = "Error,data of card\r\n"; break;
                    case 0x85: str = "Error,Incorrect input parameter or command format\r\n"; break;
                    case 0x87: str = "Unknown failure\r\n"; break;
                    case 0x89: str = "Error,Incorrect input parameter or command format\r\n"; break;
                    case 0x8A: str = "Initial block error\r\n"; break;
                    case 0x8B: str = "Wrong card Serial Number in the anti-collision\r\n"; break;
                    case 0x8C: str = "Password Authentication failed\r\n"; break;
                    case 0x8F: str = "Error,Input command code not exist\r\n"; break;
                    case 0x90: str = "The card were unmatched for the command\r\n"; break;
                    case 0x91: str = "Error in order format\r\n"; break;
                    case 0x92: str = "Unmatched FLAG parameter and OPTION parameter\r\n"; break;
                    case 0x93: str = "Inexistent block\r\n"; break;
                    case 0x94: str = "Locked,unchangeable operation\r\n"; break;
                    case 0x95: str = "Locking operation unsuccessfully\r\n"; break;
                    case 0x96: str = "Write operation unsuccessfully\r\n"; break;
                    default: str = "Not defined error\r\n"; break;
                }
            }
            else // Bahasa Indonesia
            {
                switch (buf)
                {
                    case 0x00: str = "Perintah berhasil dijalankan\r\n"; break;
                    case 0x01: str = "Gagal menjalankan perintah (lihat detail fungsi)\r\n"; break;
                    case 0x80: str = "Parameter berhasil disetel\r\n"; break;
                    case 0x81: str = "Gagal menyetel parameter\r\n"; break;
                    case 0x82: str = "Waktu komunikasi habis\r\n"; break;
                    case 0x83: str = "Kartu tidak ada\r\n"; break;
                    case 0x84: str = "Kesalahan membaca data kartu\r\n"; break;
                    case 0x85: str = "Parameter masukan atau format perintah salah\r\n"; break;
                    case 0x87: str = "Kesalahan tidak diketahui\r\n"; break;
                    case 0x89: str = "Parameter masukan atau format perintah salah\r\n"; break;
                    case 0x8A: str = "Kesalahan saat inisialisasi blok\r\n"; break;
                    case 0x8B: str = "Nomor seri kartu salah dalam proses anti-tabrakan\r\n"; break;
                    case 0x8C: str = "Autentikasi sandi gagal\r\n"; break;
                    case 0x8F: str = "Kode perintah tidak dikenal\r\n"; break;
                    case 0x90: str = "Kartu tidak mendukung perintah ini\r\n"; break;
                    case 0x91: str = "Format perintah salah\r\n"; break;
                    case 0x92: str = "Parameter FLAG dan OPTION tidak cocok\r\n"; break;
                    case 0x93: str = "Blok tidak ada\r\n"; break;
                    case 0x94: str = "Objek terkunci, tidak dapat diubah\r\n"; break;
                    case 0x95: str = "Operasi penguncian gagal\r\n"; break;
                    case 0x96: str = "Operasi penulisan gagal\r\n"; break;
                    default: str = "Kesalahan tidak terdefinisi\r\n"; break;
                }
            }
            return str;
        }
    }
}
