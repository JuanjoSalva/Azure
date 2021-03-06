using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Transactions;
using System;
using DAL.Repository;
using DAL.Models;
using DAL.Database;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;



namespace DAL.Test
{
    [TestClass]
    public class BookingRepositoryTests
    {
            private DbContextOptions<MyDbContext> _options =
            new DbContextOptionsBuilder<MyDbContext>()
                .UseSqlite(@"Data Source =E:\JUANJO\CURSO2020\MODULO4_AZURE\20487D\AllFiles\Mod02\LabFiles\Lab2\Database\SqliteHotel.db")
                .Options;

        [TestMethod]
        public  async Task TestMethod1()
        {
            Booking fristBooking;
            Booking secondBooking;
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required,
                    new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }, TransactionScopeAsyncFlowOption.Enabled))
            {
                HotelBookingRepository repository = new HotelBookingRepository();
                fristBooking = await repository.Add(1, 1, DateTime.Now.AddDays(6), 4);
                secondBooking = await repository.Add(1, 2, DateTime.Now.AddDays(8), 3);
                scope.Complete();
            }

            using (MyDbContext context = new MyDbContext())
            {
                int bookingsCounter = context.Bookings.Where(booking => booking.BookingId == fristBooking.BookingId ||
                                                                        booking.BookingId == secondBooking.BookingId).ToList().Count;
                Assert.AreEqual(2, bookingsCounter);
            }
        }




        [TestMethod]
     public async Task AddTwoBookingsSQLiteTest()
     {
         using (MyDbContext context = new MyDbContext(_options))
         {

             HotelBookingRepository repository = new HotelBookingRepository(_options);
             Booking fristBooking = await repository.Add(1, 1, DateTime.Now.AddDays(6), 4);
             Booking secondBooking = await repository.Add(1, 2, DateTime.Now.AddDays(8), 3);

             int bookingsCounter = context.Bookings.Where(booking => booking.BookingId == fristBooking.BookingId ||
                                                                     booking.BookingId == secondBooking.BookingId).ToList().Count;

             Assert.AreEqual(2, bookingsCounter);
         }
     }


    }
}
