using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqHotelsExercice
{
    class Program
    {
        static void Main(string[] args)
        {
            var hotels = new Hotel[]
            {
                new Hotel() {HotelNo = 1, Name = "The Pope", Address = "Vaticanstreet 1  1111 Bishopcity"},
                new Hotel() {HotelNo = 2, Name = "Lucky Star", Address = "Lucky Road 12  2222 Hometown"},
                new Hotel() {HotelNo = 3, Name = "Discount", Address = "Inexpensive Road 7 3333 Cheaptown"},
                new Hotel() {HotelNo = 4, Name = "deLuxeCapital", Address = "Luxury Road 99  4444 Luxus"},
                new Hotel() {HotelNo = 5, Name = "Discount", Address = "Inexpensive Road 7 3333 Cheaptown"},
                new Hotel() {HotelNo = 6, Name = "Prindsen", Address = "Algade 5, 4000 Roskilde"},
                new Hotel() {HotelNo = 7, Name = "Scandic", Address = "Algade 5, 4000 Roskilde"},
            };

            var rooms = new Room[]
            {
                new Room() {RoomNo = 1, Hotel=hotels[0], Types = 'D', Price = 200},
                new Room() {RoomNo = 2, Hotel=hotels[0], Types = 'D', Price = 200},
                new Room() {RoomNo = 3, Hotel=hotels[0], Types = 'D', Price = 200},
                new Room() {RoomNo = 4, Hotel=hotels[0], Types = 'D', Price = 200},
                new Room() {RoomNo = 11, Hotel=hotels[0], Types = 'S', Price = 150},
                new Room() {RoomNo = 12, Hotel=hotels[0], Types = 'S', Price = 150},
                new Room() {RoomNo = 13, Hotel=hotels[0], Types = 'S', Price = 150},
                new Room() {RoomNo = 21, Hotel=hotels[0], Types = 'F', Price = 220},
                new Room() {RoomNo = 22, Hotel=hotels[0], Types = 'F', Price = 220},
                new Room() {RoomNo = 23, Hotel=hotels[0], Types = 'F', Price = 220},
                new Room() {RoomNo = 1, Hotel=hotels[1], Types = 'D', Price = 230},
                new Room() {RoomNo = 2, Hotel=hotels[1], Types = 'D', Price = 230},
                new Room() {RoomNo = 3, Hotel=hotels[1], Types = 'D', Price = 230},
                new Room() {RoomNo = 4, Hotel=hotels[1], Types = 'D', Price = 230},
                new Room() {RoomNo = 11, Hotel=hotels[1], Types = 'S', Price = 180},
                new Room() {RoomNo = 12, Hotel=hotels[1], Types = 'S', Price = 180},
                new Room() {RoomNo = 21, Hotel=hotels[1], Types = 'F', Price = 300},
                new Room() {RoomNo = 22, Hotel=hotels[1], Types = 'F', Price = 300},
                new Room() {RoomNo = 1, Hotel=hotels[2], Types = 'D', Price = 175},
                new Room() {RoomNo = 2, Hotel=hotels[2], Types = 'D', Price = 180},
                new Room() {RoomNo = 11, Hotel=hotels[2], Types = 'S', Price = 100},
                new Room() {RoomNo = 21, Hotel=hotels[2], Types = 'S', Price = 100},
                new Room() {RoomNo = 31, Hotel=hotels[2], Types = 'F', Price = 200},
                new Room() {RoomNo = 32, Hotel=hotels[2], Types = 'F', Price = 230},
                new Room() {RoomNo = 1, Hotel=hotels[3], Types = 'D', Price = 500},
                new Room() {RoomNo = 2, Hotel=hotels[3], Types = 'D', Price = 550},
                new Room() {RoomNo = 3, Hotel=hotels[3], Types = 'D', Price = 550},
                new Room() {RoomNo = 11, Hotel=hotels[3], Types = 'S', Price = 350},
                new Room() {RoomNo = 12, Hotel=hotels[3], Types = 'S', Price = 360},
                new Room() {RoomNo = 1, Hotel=hotels[4], Types = 'D', Price = 250},
                new Room() {RoomNo = 2, Hotel=hotels[4], Types = 'D', Price = 170},
                new Room() {RoomNo = 11, Hotel=hotels[4], Types = 'S', Price = 150},
                new Room() {RoomNo = 21, Hotel=hotels[4], Types = 'F', Price = 300},
                new Room() {RoomNo = 22, Hotel=hotels[4], Types = 'F', Price = 310},
                new Room() {RoomNo = 23, Hotel=hotels[4], Types = 'F', Price = 320},
                new Room() {RoomNo = 24, Hotel=hotels[4], Types = 'F', Price = 320},
                new Room() {RoomNo = 1, Hotel=hotels[5], Types = 'D', Price = 290},
                new Room() {RoomNo = 11, Hotel=hotels[5], Types = 'S', Price = 185},
                new Room() {RoomNo = 21, Hotel=hotels[5], Types = 'F', Price = 360},
                new Room() {RoomNo = 22, Hotel=hotels[5], Types = 'F', Price = 370},
                new Room() {RoomNo = 23, Hotel=hotels[5], Types = 'F', Price = 380},
                new Room() {RoomNo = 24, Hotel=hotels[5], Types = 'F', Price = 380},
                new Room() {RoomNo = 1, Hotel=hotels[6], Types = 'D', Price = 200},
                new Room() {RoomNo = 2, Hotel=hotels[6], Types = 'D', Price = 200},
                new Room() {RoomNo = 3, Hotel=hotels[6], Types = 'D', Price = 200},
                new Room() {RoomNo = 4, Hotel=hotels[6], Types = 'D', Price = 200},
                new Room() {RoomNo = 11, Hotel=hotels[6], Types = 'S', Price = 150},
                new Room() {RoomNo = 12, Hotel=hotels[6], Types = 'S', Price = 150},
                new Room() {RoomNo = 13, Hotel=hotels[6], Types = 'S', Price = 150},
                new Room() {RoomNo = 14, Hotel=hotels[6], Types = 'S', Price = 150},
                new Room() {RoomNo = 21, Hotel=hotels[6], Types = 'F', Price = 220},
                new Room() {RoomNo = 22, Hotel=hotels[6], Types = 'F', Price = 220},
                new Room() {RoomNo = 23, Hotel=hotels[6], Types = 'F', Price = 220},
                new Room() {RoomNo = 24, Hotel=hotels[6], Types = 'F', Price = 220}
            };

            //Exercise, use LINQ to retrive the following information about Hotels and Rooms:

            // 1) List full details of all Hotels:
            var allHotels =
                from hotel in hotels
                select hotel;

            Console.WriteLine("Full details of all hotels:");
            foreach (var hotel in allHotels)
            {
                Console.WriteLine("{0}, {1}, {2}", hotel.HotelNo, hotel.Name, hotel.Address);
            }
            Console.WriteLine("");


            // 2) List full details of all hotels in Roskilde:
            var detailsRoskilde =
                from hotel in hotels
                where hotel.Address.Contains("Roskilde")
                select hotel;

            Console.WriteLine("Full details of hotels in Roskilde:");
            foreach (var hotel in detailsRoskilde)
            {
                Console.WriteLine("{0}, {1}, {2}", hotel.HotelNo, hotel.Name, hotel.Address);
            }
            Console.WriteLine("");


            // 3) List the names of all hotels in Roskilde:
            IEnumerable<string> hotelRoskilde =
                from hotel in hotels
                where hotel.Address.Contains("Roskilde")
                select hotel.Name;

            Console.WriteLine("Hotels in Roskilde:");
            foreach (string hotel in hotelRoskilde)
            {
                Console.WriteLine(hotel);
            }
            Console.WriteLine("");


            // 4) List all double rooms with a price below 400 pr night:
            var doubleRoomsBelow400 =
                from room in rooms
                where room.Types == 'D' && room.Price < 400
                select room;

            Console.WriteLine("Double rooms with a price below 400:");
            foreach (var room in doubleRoomsBelow400)
            {
                Console.WriteLine("Room number: {0} from {1}", room.RoomNo, room.Hotel.Name);
            }
            Console.WriteLine("");

            // 5) List all double or family rooms with a price below 400 pr night in ascending order of price:
            var familyRoomBelow400 =
                from room in rooms
                where room.Types == 'F' && room.Price < 400
                orderby room.Price ascending
                select room;

            Console.WriteLine("Family rooms with a price below 400 in ascending order:");
            foreach (var room in familyRoomBelow400)
            {
                Console.WriteLine("Room number: {0} in {1} which costs {2}", room.RoomNo, room.Hotel.Name, room.Price);
            }
            Console.WriteLine("");

            // 6) List all hotels that starts with 'P':
            var hotelsWithP =
                from hotel in hotels
                where hotel.Name.StartsWith("P")
                select hotel.Name;

            Console.WriteLine("Hotels that starts with 'P':");
            foreach (string hotel in hotelsWithP)
            {
                Console.WriteLine(hotel);
            }
            Console.WriteLine("");

            // 7) List the number of hotels:
            var numberOfHotels =
                from hotel in hotels
                select hotel;

            Console.WriteLine("Total number of hotels:");
            Console.WriteLine("{0}", numberOfHotels.Count());
            Console.WriteLine("");

            // 8) List the number of hotels in Roskilde:
            var numberOfHotelsRoskilde =
                from hotel in hotels
                where hotel.Address.Contains("Roskilde")
                select hotel.Name;

            Console.WriteLine("Number of hotels in Roskilde");
            Console.WriteLine("{0}", numberOfHotelsRoskilde.Count());
            Console.WriteLine("");

            // 9) what is the avarage price of a room:
            var averagePriceOfOneRoom =
                from room in rooms
                let totalPrice = room.Price
                select totalPrice;

            double totalAveragePrice = averagePriceOfOneRoom.Average();
            Console.WriteLine("The average price of a room is:");
            Console.WriteLine("{0}", totalAveragePrice);
            Console.WriteLine("");

            //10) what is the avarage price of a room at Hotel Scandic:
            var averagePriceAtScandic =
                from room in rooms
                where room.Hotel.HotelNo == 7
                let totalPrice = room.Price
                select totalPrice;

            double averagePrice = averagePriceAtScandic.Average();
            Console.WriteLine("The average price of a room at Hotel Scandic is:");
            Console.WriteLine("{0}", averagePrice);
            Console.WriteLine("");

            //11) what is the total reveneue per night from all double rooms:
            var totalRevenuePerNight =
                from room in rooms
                where room.Types == 'D'
                select room.Price;

            double totalRevenue = 0;
            Console.WriteLine("Total revenue per night from all double rooms is:");

            foreach (var i in totalRevenuePerNight)
            {
                totalRevenue += i;
            }
            Console.WriteLine(totalRevenue);

            //12) List price and type of all rooms at Hotel Prindsen:
            var priceAndTypePrindsen =
                from room in rooms
                where room.Hotel.HotelNo == 6
                select room;

            Console.WriteLine("\nType and price of all rooms at Hotel Prindsen:");
            foreach (var room in priceAndTypePrindsen)
            {
                Console.WriteLine("Roomnumber: {0}, Type: {1} costs: {2}", room.RoomNo, room.Types, room.Price);
            }

            //13) List distinct price and type of all rooms at Hotel Prindsen:
            var priceAndTypePrindsenDistinct =
                from room in rooms
                where room.Hotel.HotelNo == 6
                select new
                {
                    room.Price,
                    room.Types
                };

            priceAndTypePrindsenDistinct = priceAndTypePrindsenDistinct.Distinct();

            foreach (var room in priceAndTypePrindsenDistinct)
            {
                Console.WriteLine("Type: {0} costs: {1}", room.Types, room.Price);
            }


            Console.ReadKey();
        }
    }
}
