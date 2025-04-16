using System.Security.Cryptography.X509Certificates;
using Jurnal08;

class Program
{
    static void Main(string[] args)
    {
        int harga;
        int method;
        String CONFIRM;
        BankTransferConfig x = new BankTransferConfig();
        x.ReadJSON();

        if (x.lang == "en")
        {
            Console.WriteLine("Please insert the amount of money to transfer:");
            string b = Console.ReadLine();
            harga = Convert.ToInt32(b);
            if (harga < x.transfer.threshold)
            {
                harga += x.transfer.low_fee;
                Console.WriteLine("Transfer fee =" + x.transfer.low_fee);
                Console.WriteLine("Total amount = " + harga);
            }
            else
            {
                harga += x.transfer.high_fee;
                Console.WriteLine("Transfer fee =" + x.transfer.high_fee);
                Console.WriteLine("Total amount = " + harga);
            } 


            for (int i = 0; i < x.methods.Count; i++)
            {
                Console.WriteLine("Transfer method " + (i + 1) + " = " + x.methods[i]);
            }
            method = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Please type {x.confirmation.en} to confirm the transaction:");
            CONFIRM = Console.ReadLine();
            if (CONFIRM == x.confirmation.en)
            {
                Console.WriteLine("Transaction Success");
            }
            else
            {
                Console.WriteLine("Transaction Failed");
            }
        }
        else
        {
            Console.WriteLine("Masukkan jumlah uang yang akan di-transfer:");
            harga = Convert.ToInt32(Console.ReadLine());
            if (harga < x.transfer.threshold)
            {
                harga += x.transfer.low_fee;
                Console.WriteLine("Biaya transfer =" + x.transfer.high_fee);
                Console.WriteLine("Total biaya = " + harga);
            }
            else
            {
                harga += x.transfer.high_fee;
                Console.WriteLine("Biaya transfer =" + x.transfer.low_fee);
                Console.WriteLine("Total biaya = "+ harga);
            }
        }


        for (int i = 0; i < x.methods.Count; i++)
        {
            Console.WriteLine("Pilih Metode Transfer:" + (i + 1) + " = " + x.methods[i]);
        }
        method = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Please type {x.confirmation.id} to confirm the transaction:");
        CONFIRM = Console.ReadLine();

        if (CONFIRM == x.confirmation.id)
        {
            Console.WriteLine("Transaction Success");
        }
        else
        {
            Console.WriteLine("Transaction Failed");
        }
    }
}