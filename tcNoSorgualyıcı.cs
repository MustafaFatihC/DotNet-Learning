
class person
{
    private string tcNo;

    public string TCNO
    {
        get
        {
            if (tcNo == null || tcNo.Length != 11)
            {
                return "Geçersiz tc no";
            }
            else
            {
                return tcNo.Substring(0, 5) + "******";
            }

        }

        set
        {
            bool kontrol = false;
            if (value.Length == 11)
            {
                for (int i = 0; i < value.Length; i++)
                {
                    bool sayıMı = char.IsNumber(value[i]);
                    if (sayıMı)
                    {

                    }
                    else
                    {
                        kontrol = true;
                        break;
                    }
                }
                if (kontrol)
                {
                    System.Console.WriteLine("Tc no sayı olarak girilmeli");
                }
                else
                {
                    tcNo = value;
                }
            }
            else
            {

                System.Console.WriteLine("Tc nonuz 11 haneli olmalı");
            }

        }
    }
}


