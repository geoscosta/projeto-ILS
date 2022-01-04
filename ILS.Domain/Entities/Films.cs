using System;
using System.Collections.Generic;

namespace ILS.Domain.Entities
{
    public class Films : Base {
        public string Title { get; private set; }
        public int ParentalRating { get; private set; }
        public int Launch { get; private set; }


        public Films(string title, int parentalRating, int launch)
        {
            Title = title;
            ParentalRating = parentalRating;
            Launch = launch;
            _errors = new List<string>();
        }

        public void ChangeFilms(string title, int parentalRating, int launch){
            Title = title;
            ParentalRating = parentalRating;
            Launch = launch;
        }
        public override bool Validate()
        {
            throw new NotImplementedException();
        }
    }
}