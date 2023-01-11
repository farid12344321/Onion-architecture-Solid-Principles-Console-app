using DomainLayer.Entities;
using ServiceLayer.Helpers;
using ServiceLayer.ServicesLayer;
using ServiceLayer.ServicesLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Practices.Controllers
{
    public class LibrraryController
    {

        private readonly ILibraryService _libraryService;
        public LibrraryController()
        {
            _libraryService = new LibraryService();
        }
        public void Create()
        {
            ConsoleColor.DarkCyan.WriteConsole("Please add library name : ");

            LibraryName: string libraryName=Console.ReadLine();


            ConsoleColor.DarkCyan.WriteConsole("Please add library seat count : ");

            SeatCount: string seatCountStr =Console.ReadLine();

            int seatCount;

            bool isCorrectSeatCount=int.TryParse(seatCountStr, out seatCount);

            if (isCorrectSeatCount)
            {
                try
                {
                    Library library = new Library()
                    {
                        Name = libraryName,
                        SeatCount = seatCount
                    };


                    var respons = _libraryService.Create(library);
                    ConsoleColor.Green.WriteConsole($"{respons.Id}  {respons.Name}  {respons.SeatCount}");
                }
                catch (Exception ex)
                {
                    ConsoleColor.Red.WriteConsole(ex.Message);
                    goto LibraryName;
                }
              
            }
            else
            {
                ConsoleColor.Red.WriteConsole("Please add correct format seat count");
                goto SeatCount;
            }
            
             
        }
    }
}
