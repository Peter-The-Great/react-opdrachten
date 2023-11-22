using Microsoft.AspNetCore.Mvc;
using reactnet_tutorial.Models;
namespace reactnet_tutorial.Controllers;

[ApiController]
[Route("[controller]")]
public class BookingController : ControllerBase
{
    private readonly List<Booking> _bookings = new List<Booking>();

    // GET: api/bookings
    [HttpGet]
    public IEnumerable<Booking> GetBookings()
    {
        return _bookings;
    }

    // POST: api/bookings
    [HttpPost]
    public IActionResult CreateBooking(Booking booking)
    {
        // Here you would typically save the booking to a database,
        // for simplicity, let's just add it to the list
        _bookings.Add(booking);
        return Ok(booking);
    }

    // GET: api/bookings/{id}
    [HttpGet("{id}")]
    public IActionResult GetBooking(int id)
    {
        var booking = _bookings.Find(b => b.Id == id);
        if (booking == null)
        {
            return NotFound();
        }
        return Ok(booking);
    }

    // PUT: api/bookings/{id}
    [HttpPut("{id}")]
    public IActionResult UpdateBooking(int id, Booking updatedBooking)
    {
        var booking = _bookings.Find(b => b.Id == id);
        if (booking == null)
        {
            return NotFound();
        }

        // Update properties based on updatedBooking
        
        return Ok(booking);
    }

    // DELETE: api/bookings/{id}
    [HttpDelete("{id}")]
    public IActionResult DeleteBooking(int id)
    {
        var booking = _bookings.Find(b => b.Id == id);
        if (booking == null)
        {
            return NotFound();
        }
        _bookings.Remove(booking);
        return Ok(booking);
    }
}

