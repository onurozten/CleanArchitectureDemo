using Core.Persistance.Repositories;
using Domain.Enums;

namespace Domain.Entities;

public class Car : Entity<Guid>
{
    public Guid ModelId { get; set; }
    public int Kilometer { get; set; }
    public short ModelYear { get; set; }
    public string Plate { get; set; }
    public short MinFindexScore { get; set; }
    public CarState CarState { get; set; }

    public virtual Model? Model { get; set; }

    public Car()
    {
        
    }

    public Car(Guid id, int kilometer, short modelyear, string plate, short minfindexscore, CarState carState)
        : this() 
    {
        Id = id;
        Kilometer = kilometer;
        ModelYear = modelyear;
        Plate = plate;
        MinFindexScore = minfindexscore;
        CarState = carState;
    }

}
