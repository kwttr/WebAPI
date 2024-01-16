﻿using SimbirSoft.Data;
using SimbirSoft.Models;
using SimbirSoft.Repositories.Interfaces;

namespace SimbirSoft.Repositories.Implementations
{
    public class AnimalTypeRepository : Repository<AnimalType>, IAnimalTypeRepository
    {
        private readonly ApplicationDbContext _db;

        public AnimalTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
