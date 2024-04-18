using System.Text;

byte[] file = File.ReadAllBytes(@"C:\Users\CL\Desktop\LOSTARK_dump.exe");

for (int i = 0; i < file.Length; i++)
{
    if (i + 27 < file.Length &&
        file[i] == 0xc7 && file[i + 1] == 0x45 &&
        file[i + 7] == 0xc7 && file[i + 8] == 0x45 &&
        file[i + 14] == 0xc7 && file[i + 15] == 0x45 &&
        file[i + 21] == 0xc7 && file[i + 22] == 0x45 &&
        file[i + 23] - file[i + 16] == 0x4 &&
        file[i + 16] - file[i + 9] == 0x4 &&
        file[i + 9] - file[i + 2] == 0x4)
    {
        StringBuilder sb = new StringBuilder();

        for (int j = i + 3; j <= i + 6; j++)
        {
            sb.Append(file[j].ToString("x2"));
        }

        for (int j = i + 10; j <= i + 13; j++)
        {
            sb.Append(file[j].ToString("x2"));
        }

        for (int j = i + 17; j <= i + 20; j++)
        {
            sb.Append(file[j].ToString("x2"));
        }

        for (int j = i + 24; j <= i + 27; j++)
        {
            sb.Append(file[j].ToString("x2"));
        }

        Console.WriteLine(sb.ToString());
    }
}