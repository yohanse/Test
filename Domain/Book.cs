using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain;
public class Book : BaseEntity
{
    public string Title { get; set; } = "";
    public Genere genere {get; set;}
    public DateTime ReleaseYear {get; set;}
    public User Author { get; set; }
    public int UserId { get; set; }
}


public enum Genere
{
    Good,
    Bad,
    NotBad,
    NotGood,
}


