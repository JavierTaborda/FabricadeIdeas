using FabricaIdeas.Models;
using System.Collections.Generic;

namespace FabricaIdeas.Data
{
    public interface IIdeasService
    {
        List<Idea> ideas { get; set; }
        List<Objetivo> objetivos { get; set; }
        List<Respon> responsables { get; set; }
        List<Area> areas { get; set; }
        List<Zona> zonas { get; set; }
        List<Estatus> estatus { get; set; }
        List<Categorium> categorias { get; set; }
         List<Premiacion> premio { get; set; }
        //Ideassssssssss
        Task GetIdeas(int Area, DateTime f1, DateTime f2);
        Task<Idea> GetIdeaData(int id);
        Task<List<Objetivo>> GetObjData(int id);
        Task<List<Respon>> GetResData(int id);
        Task<Idea> InsertIdea(Idea idea);
        Task<Idea>UpdateIdea(int id);      
        Task<List<Objetivo>>InsertObjetivo( Objetivo objetivos,int ididea);
        Task<List<Respon>>InsertResponsable(Respon res, int ididea);



        /*ZONASSSSS*/
        Task InsertZona(Zona zona);
        Task InsertArea(Area area);

        Task GetZona();
        Task GetArea();

        //Estatus de idea
        Task GetEstatus();

        //Premiaciones y categorias
        Task GetPremiacion();
        Task GetCategoria();

    }
}
