using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_Bai2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // bai 09/08
            /*            // calculator
                         Calculator myCal = new Calculator(12,1);
                         Console.WriteLine($"Add: {myCal.Add()}");
                         Console.WriteLine($"Subtract: {myCal.Subtract()}");
                         Console.WriteLine($"Multiply: {myCal.Multiply()}");
                         Console.WriteLine($"Divide: {myCal.Divide()}");


                        // phan so
                         Console.WriteLine("Nhap phan so 1");
                         Phanso ps1 = new Phanso();
                         ps1.Nhap();

                         Console.WriteLine("Nhap phan so 2");
                         Phanso ps2 = new Phanso();
                         ps2.Nhap();

                         Console.WriteLine("Add");
                         ps1.Add(ps2).Xuat();
                         Console.WriteLine("Subtract");
                         ps1.Subtract(ps2).Xuat();
                         Console.WriteLine("Multiply");
                         ps1.Multiply(ps2).Xuat();
                         Console.WriteLine("Divide");
                         ps1.Divide(ps2).Xuat();



                        DateTime time1 = DateTime.Now;
                        MyDateTime time2;
                        try
                        {
                            time2 = MyDateTime.createFromString("2024-08-07 16:46:05");
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine(ex.Message);
                            return;
                        }

                        Console.WriteLine("Created MyDateTime object 1: " + time1.ToString("yyyy-MM-dd HH:mm:ss"));
                        Console.WriteLine("Created MyDateTime object 2: " + time2.ToString());

                        //add minutes
                        MyDateTime AddTime = time2.AddMinutes(30);
                        Console.WriteLine("Created MyDateTime object add time: " + AddTime.ToString());

                        // diffInMinutes
                        MyDateTime myTime1 = new MyDateTime(time1);
                        int diffInMinutes = myTime1.DiffInMinutes(AddTime);
                        Console.WriteLine("Result DiffInMinutes: " + diffInMinutes);

                        //check month
                        myTime1.IsSameMonth(AddTime);

                        // check Thursday
                        myTime1.IsThursday(AddTime);*/

            // 08/08
            /* string[] emails = {
             "ducpa@kiaisoft.com",
             "ducpa+3@kiaisoft.com",
             "ducpa+3+3@kiaisoft.com",
             "ducpa+admin@kiaisoft.com",
             "ducpa2@kiaisoft.com",
             "ungnv+1@kiaisoft.com",
             "ungnv+11@kiaisoft.com",
             "1+ungnv@kiaisoft.com",
             "tuyennt+a@kiaisoft.com",
             "tuyennt.admin@kiaisoft.com",
             "tuyennt+admin@kiaisoft.com",
             "tuyennt-admin@kiaisoft.com"
             };

             FilterEmails filterEmails = new FilterEmails();
             List<string> mail = filterEmails.FilterEmail(emails);

             foreach (string mailItem in mail)
             {
                 Console.WriteLine(mailItem);
             }*/


            // 10/08 bai1
            /*            Console.WriteLine("Nhap email: ");
                        string emailUser = Console.ReadLine();
                        Console.WriteLine("Nhap password: ");
                        string passUser = Console.ReadLine();

                        User user = new User(emailUser, passUser);
                        user.Login();*/

            // 10/08 bai2

            /*Console.WriteLine("hay nhap phuong thuc thanh toan mon hang ban mua(1->3)??");
            int x = int.Parse(Console.ReadLine());
            switch (x)
            {
                case 1:
                    PaymentMethod cashPayment = new CashPayment(displaymessage:true);
                    cashPayment.Login();
                    cashPayment.Payment();
                    break;
                case 2:
                    PaymentMethod payPalPayment = new PaypalPayment(displaymessage:true);
                    payPalPayment.Login();
                    payPalPayment.Payment();
                    break;
                default:
                    PaymentMethod visaPayment = new VisaPayment(displaymessage: true);
                    visaPayment.Login();
                    visaPayment.Payment();
                    break;
            }*/


        }
    }
}

