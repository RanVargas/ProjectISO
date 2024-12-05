using ProjectISO.Data;
using ProjectISO.Interfaces;
using ProjectISO.Models;

namespace ProjectISO.Services
{
    public class DepartamentoService : IDepartamentoService
    {
        private readonly AppDbContext _context;

        public DepartamentoService(AppDbContext context)
        {
            _context = context;
        }

        public Departamento CreateDepartamento(Departamento departamento)
        {
            _context.Departamento.Add(departamento);
            _context.SaveChanges();
            return departamento;
        }

        public bool DeleteDepartamentoById(int id)
        {
            var departamento = _context.Departamento.Find(id);
            if (departamento == null) return false;

            _context.Departamento.Remove(departamento);
            _context.SaveChanges();
            return true;
        }

        public List<Departamento> GetAllDepartamentos()
        {
            return _context.Departamento.ToList();
        }

        public Departamento GetDepartamentoById(int id)
        {
            return _context.Departamento.Find(id);
        }

        public Departamento UpdateDepartamento(Departamento departamento)
        {
            var existingDepartamento = _context.Departamento.Find(departamento);
            if (existingDepartamento == null) return null;

            // Update properties as needed
            _context.Entry(existingDepartamento).CurrentValues.SetValues(departamento);
            _context.SaveChanges();
            return existingDepartamento;
        }
    }
}
