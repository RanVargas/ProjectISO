using Microsoft.EntityFrameworkCore;
using ProjectISO.Data;
using ProjectISO.Interfaces;
using ProjectISO.Models;
using System.ServiceModel;
using System.ServiceModel.Description;


namespace ProjectISO.Services
{

    public class ActivoService : IActivoService
    {
        private readonly AppDbContext _context;

        public ActivoService(AppDbContext context)
        {
            _context = context;
        }

        public Activo CreateActivo(Activo activo)
        {
            _context.Activo.Add(activo);
            _context.SaveChanges();
            return activo;
        }

        public Activo GetActivoById(int id)
        {
            return _context.Activo.Find(id);
        }

        public List<Activo> GetAllActivos()
        {
            return _context.Activo.ToList();
        }

        public bool DeleteActivoById(int id)
        {
            var activo = _context.Activo.Find(id);
            if (activo == null) return false;

            _context.Activo.Remove(activo);
            _context.SaveChanges();
            return true;
        }

        public Activo UpdateActivo(Activo activo)
        {
            var existingActivo = _context.Activo.Find(activo.Id);
            if (existingActivo == null) return null;

            // Update properties as needed
            _context.Entry(existingActivo).CurrentValues.SetValues(activo);
            _context.SaveChanges();
            return existingActivo;
        }
    }
}
