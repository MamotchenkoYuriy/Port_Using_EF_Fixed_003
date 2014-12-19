using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using DataAccessLayer.DataContextConfiguration;
using DataAccessLayer.Manager;
using DataAccessLayer.Repository;
using DataAccessLayer.Validation;

namespace DataAccessLayer.DAO
{
    public class DAOManager
    {
        private readonly DataContext _context;
        private readonly Dictionary<string, object> _dictionaryManamers;
        private static DAOManager instance;
        private readonly Dictionary<string, object> _dictionaryRepositories; 


        private DAOManager()
        {
            _context = new DataContext();
            _dictionaryManamers = new Dictionary<string, object>();
            _dictionaryRepositories = new Dictionary<string, object>();

            //Засетим все репозитории 
            _dictionaryRepositories.Add(typeof(City).Name, new Repository.Repository<City>(_context));
            _dictionaryRepositories.Add(typeof(Cargo).Name, new Repository.Repository<Cargo>(_context));
            _dictionaryRepositories.Add(typeof(CargoType).Name, new Repository.Repository<CargoType>(_context));
            _dictionaryRepositories.Add(typeof(Trip).Name, new Repository.Repository<Trip>(_context));
            _dictionaryRepositories.Add(typeof(Captain).Name, new Repository.Repository<Captain>(_context));
            _dictionaryRepositories.Add(typeof(Ship).Name, new Repository.Repository<Ship>(_context));
            _dictionaryRepositories.Add(typeof(Port).Name, new Repository.Repository<Port>(_context));




            _dictionaryManamers.Add(typeof(Trip).Name, new Mamager001<Trip>((IRepository<Trip>)_dictionaryRepositories[typeof(Trip).Name], new TripValidator((IRepository<Trip>)_dictionaryRepositories[typeof(Trip).Name])));

            _dictionaryManamers.Add(typeof(City).Name, new Mamager001<City>((IRepository<City>)_dictionaryRepositories[typeof(City).Name], new CityValidator((IRepository<City>)_dictionaryRepositories[typeof(City).Name])));

            _dictionaryManamers.Add(typeof(Cargo).Name, new Mamager001<Cargo>((IRepository<Cargo>)_dictionaryRepositories[typeof(Cargo).Name], new CargoValidator((IRepository<Cargo>)_dictionaryRepositories[typeof(Cargo).Name])));

            _dictionaryManamers.Add(typeof(CargoType).Name, new Mamager001<CargoType>((IRepository<CargoType>)_dictionaryRepositories[typeof(CargoType).Name], new CargoTypeValidator((IRepository<CargoType>)_dictionaryRepositories[typeof(CargoType).Name])));

            _dictionaryManamers.Add(typeof(Ship).Name, new Mamager001<Ship>((IRepository<Ship>)_dictionaryRepositories[typeof(Ship).Name], new ShipValidator((IRepository<Ship>)_dictionaryRepositories[typeof(Ship).Name])));

            _dictionaryManamers.Add(typeof(Captain).Name, new Mamager001<Captain>((IRepository<Captain>)_dictionaryRepositories[typeof(Captain).Name], new CaptainValidator((IRepository<Captain>)_dictionaryRepositories[typeof(Captain).Name])));

            _dictionaryManamers.Add(typeof(Port).Name, new Mamager001<Port>((IRepository<Port>)_dictionaryRepositories[typeof(Port).Name], new PortValidator((IRepository<Port>)_dictionaryRepositories[typeof(Port).Name])));

        }

        public static DAOManager GetInstance()
        {
            if (instance != null)
            {
                return instance;
            }
            instance = new DAOManager();
            return instance;
        }

        public IManager<T> Manager<T>() where T :BaseEntity
        {
            if (_dictionaryManamers.ContainsKey(typeof (T).Name))
            {
                return (IManager<T>)_dictionaryManamers[typeof (T).Name];
            }
            throw new ObjectNotFoundException();
        } 
    }
}
