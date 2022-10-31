using FabricaIdeas.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

namespace FabricaIdeas.Data
{
    public class IdeaService : IIdeasService
    {
        public List<Idea> ideas { get; set; }
        public List<Objetivo> objetivos { get ; set; }
        public List<Respon> responsables { get; set; }
        public List<Area> areas { get; set; }
        public List<Zona> zonas { get; set; }
        public List<Estatus> estatus { get; set; }
        public List<Categorium> categorias { get; set; }
        public List<Premiacion> premio { get; set; }


        private readonly DbFabriIdeasContext _context;
        private readonly NavigationManager _navigationManager;
        public IdeaService(DbFabriIdeasContext _dbFabriIdeasContext, NavigationManager navigationManager)
        {
            _navigationManager = navigationManager;
            _context = _dbFabriIdeasContext;
        }

        public async Task GetIdeas()
        {
            ideas = await _context.Ideas.ToListAsync();
        }

        public async Task<Idea> InsertIdea(Idea idea)
        {
            _context.Ideas.Add(idea);
            await _context.SaveChangesAsync();
            return idea;
        }
        public async Task<Idea> GetIdeaData(int id)
        {

            var idea = await _context.Ideas
            .FirstOrDefaultAsync(h => h.IdIdea == id);
            if (idea == null)
                throw new Exception("not found!");
            return idea;
        }

        public async Task InsertObjetivo(Objetivo obj)
        {

            _context.Objetivos.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task InsertResponsables(Respon res)
        {
            _context.Respons.Add(res);
            await _context.SaveChangesAsync();
        }

        public Task<Idea> UpdateIdea(int id)
        {
            throw new NotImplementedException();
        }

        public async Task InsertZona(Zona zona)
        {
            _context.Zonas.Add(zona);
            await _context.SaveChangesAsync();
        }

        public async Task InsertArea(Area area)
        {
            _context.Areas.Add(area);
            await _context.SaveChangesAsync();
        }

        public async Task GetZona()
        {
            zonas = await _context.Zonas
                .Where(a => a.Zesta == true)
                .ToListAsync();
        }

        public async Task GetArea()
        {
            areas = await _context.Areas
                            .Where(a => a.Aesta == true)
                            .Include(b=> b.Zonas)
                            .ToListAsync();
        }

        public async Task GetEstatus()
        {
            estatus = await _context.Estatuses
                           .Where(a => a.Eesta == true)
                           .ToListAsync();
        }

        public async Task GetPremiacion()
        {
            premio = await _context.Premiacions
                .Include(b => b.CidCatNavigation)
                           .ToListAsync();
        }

        public async Task GetCategoria()
        {
            categorias = await _context.Categoria
                           .ToListAsync();
        }
    }
}
