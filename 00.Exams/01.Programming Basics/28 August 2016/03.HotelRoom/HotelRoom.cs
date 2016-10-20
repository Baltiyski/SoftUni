using System;

class HotelRoom
{
    static void Main(string[] args)
    {
        string month = Console.ReadLine();
        int daysInHotel = int.Parse(Console.ReadLine());

        //May, June, July, August, September или October

        double studio = 0;
        double apartment = 0;
        switch (month)
        {
            case "May":
            case "October":
                studio = 50;
                apartment = 65;
                if (daysInHotel > 7 && daysInHotel < 14)
                {
                    studio =  studio - (studio * 0.05);
                }
                if (daysInHotel > 14)
                {
                    studio = studio - (studio * 0.3);
                }
                if (daysInHotel > 14)
                {
                    apartment = apartment - (apartment * 0.1);
                }
                Console.WriteLine("Apartment: {0:F2} lv.", daysInHotel * apartment);
                Console.WriteLine("Studio: {0:F2} lv.", daysInHotel * studio);
                break;
            case "June":
            case "September":
                studio = 75.20;
                apartment = 68.70;

                if (daysInHotel > 14)
                {
                    studio = studio - (studio * 0.2);
                }
                if (daysInHotel > 14)
                {
                    apartment = apartment - (apartment * 0.1);
                }
                Console.WriteLine("Apartment: {0:F2} lv.", daysInHotel * apartment);
                Console.WriteLine("Studio: {0:F2} lv.", daysInHotel * studio);
                break;
            case "July":
            case "August":
                studio = 76;
                apartment = 77;

                if (daysInHotel > 14)
                {
                    apartment = apartment - (apartment * 0.1);
                }
                Console.WriteLine("Apartment: {0:F2} lv.", daysInHotel * apartment);
                Console.WriteLine("Studio: {0:F2} lv.", daysInHotel * studio);
                break;
            default:
                break;
        }
    }
}
