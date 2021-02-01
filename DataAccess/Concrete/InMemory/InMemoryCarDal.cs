using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
            new Car{Id=1, BrandId=10, ColorId=100, DailyPrice= 350, ModelYear= 2010, Description="BMW, Kırmızı, 2010 Model, Benzinli"},
            new Car{Id=2, BrandId=20, ColorId=200, DailyPrice= 500, ModelYear= 2015, Description="Mercedes, Beyaz, 2015 Model, Benzinli"},
            new Car{Id=3, BrandId=30, ColorId=300, DailyPrice= 600, ModelYear= 2018, Description="Toyota, Gri, 2018 Model, Diesel"},
            new Car{Id=4, BrandId=40, ColorId=400, DailyPrice= 450, ModelYear= 2020, Description="Opel, Siyah, 2020 Model, Diesel"},
            new Car{Id=5, BrandId=50, ColorId=500, DailyPrice= 830, ModelYear= 2017, Description="Porsche, Sarı, 2017 Model, Benzinli"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int BrandId)
        {
           return _cars.Where(c => c.BrandId == BrandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            
        }
    }
}
