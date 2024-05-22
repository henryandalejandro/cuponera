using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LuegoPago.Data;
using LuegoPago.Models;

namespace LuegoPago.Services
{
    public class CuponRepository : ICuponRepository
    {
        private readonly CuponDbContext _context;
        public CuponRepository(CuponDbContext context){
            _context = context;



        }
        public void Add(Cupon cupon)
        {
            _context.Cupones.Add(cupon);
            _context.SaveChanges();

        }

        public IEnumerable<Cupon> GetAll()
        {
            return _context.Cupones.ToList();
        }

        public Cupon GetById(int Id)
        {
            return _context.Cupones.Find(Id);
        }

        public object GetCuponById(int id)
        {
            throw new NotImplementedException();
        }

        public Task GetCuponesByIdAsync(int id)
        {
            throw new NotImplementedException();
        }


        public void Remove(int Id)
        {
            var cupon = _context.Cupones.Find(Id);
            _context.Cupones.Remove(cupon!);
            _context.SaveChanges();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }


        public void Update(Cupon cupon)
        {
            _context.Cupones.Update(cupon);
            _context.SaveChanges();
        }
    }

}