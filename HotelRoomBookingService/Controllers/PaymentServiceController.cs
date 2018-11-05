using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelRoomBookingLibrary;
using HotelRoomBookingService.Models;
using HotelRoomBookingService.Models.DB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelRoomBookingService.Controllers
{
    [Route("Admin")]
    [ApiController]
    public class BookingServiceController : ControllerBase
    {
        PaymentService service;
        public BookingServiceController()
        {
            this.service = new PaymentService();
        }


        //[Route("BookingDetails")]
        //[HttpPost]
        //public IActionResult BookingDetails(HotelSearchDetails h1)
        //{
        //    service.BookingDetails(h1);
        //    return Ok();
        //}


        [Route("BookingDetails")]
        [HttpPost]
        public IActionResult BookingDetails(HotelSearchDetails bd1)
        {
            service.AddBookingDetails(bd1);
            return Ok();
        }
    }
}
