var path = "";

FileInfo f = new FileInfo(path);
using FileStream stream = f.Open(FileMode.Open);


for (int i = 0; i < f.Length; i += 8)
{

    for (int j = 0; j < 8; j++)
    {
        int b = stream.ReadByte();
    }


}