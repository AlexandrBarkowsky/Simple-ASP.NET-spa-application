using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using SPA.Models;

namespace SPA.Controllers
{
    public class WebController : ApiController
    {
        private ReservationRepository repo = ReservationRepository.Current;
        // GET: Web
        public IEnumerable<Reservation> GetAllReservation() {
            return repo.GetAll();
        }
        public Reservation GetReservation(int id) {
            return repo.Get(id);
        }

        public Reservation PostReservation(Reservation item) {
            return repo.Add(item);
        }

        public bool PutReservation(Reservation item) {
            return repo.Update(item);
        }

        public void DeleteReservation(int id) {
            repo.Remove(id);
        }
    }
}