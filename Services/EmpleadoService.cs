using ProjectISO.Data;
using ProjectISO.Interfaces;
using ProjectISO.Models;
using System;

namespace ProjectISO.Services
{
    public class EmpleadoService : IEmpleadoService
    {
        private readonly AppDbContext _context;

        public EmpleadoService(AppDbContext context)
        {
            _context = context;
        }

        public Empleado CreateEmpleado(Empleado empleado)
        {
            _context.Empleado.Add(empleado);
            _context.SaveChanges();
            return empleado;
        }

        public bool DeleteEmpleadoById(int id)
        {
            var empleado = _context.Empleado.Find(id);
            if (empleado == null) return false;

            _context.Empleado.Remove(empleado);
            _context.SaveChanges();
            return true;
        }

        public List<Empleado> GetAllEmpleados()
        {
            return _context.Empleado.ToList();
        }

        public Empleado GetEmpleadoById(int id)
        {
            return _context.Empleado.Find(id);
        }

        public Empleado UpdateEmpleado(Empleado empleado)
        {
            var existingEmpleado = _context.Empleado.Find(empleado);
            if (existingEmpleado == null) return null;

            // Update properties as needed
            _context.Entry(existingEmpleado).CurrentValues.SetValues(empleado);
            _context.SaveChanges();
            return existingEmpleado;
        }
    }
}
