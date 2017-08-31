using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public enum Genre
    {
        Sciencefiction,
        Satire,
        Drama,
        Action,
        Adventure,
        Romance,
        Mystery,
        Horror,
        Selfhelp,
        Health,
        Guide,
        Travel,
        Children,
        Religion,
        Spirituality,
        Science,
        History,
        Math,
        Anthology,
        Poetry,
        Encyclopedias,
        Dictionaries,
        Comics,
        Art,
        Cookbooks,
        Diaries,
        Journals,
        Prayer,
        Series,
        Trilogy,
        Biographies,
        Autobiographies,
        Fantasy
    }
    public enum Status
    {
        Available,
        Unavailable
    }
    public class Book
    {
       
     
            public string Name { get; private set; }
            public Genre Category { get; private set; }
            public long ISBNNumber { get; private set; }
            public List<string> AuthorName { get; private set; }
            public int Edition { get; private set; }
            public Status Status { get; private set; }
          


            public Book(string name, Genre genre, long isbn, List<string> authorname, int edition, Status status)
            {
                Name = name;
                Category = genre;
                ISBNNumber = isbn;
                AuthorName = authorname;
                Edition = edition;
                Status = status;
               
            }

            public override string ToString()
            {
                return Name + " " + Category + " " + ISBNNumber + " " + AuthorName + " " + Edition + " " + Status;
            }

        }
    }


