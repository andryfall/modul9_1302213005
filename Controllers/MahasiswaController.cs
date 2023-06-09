﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace modul9_1302213005.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        
        public static List<string> c = new List<string> { "KPL", "BD", "PBO"};
        
        private static List<Mahasiswa> mahasiswaList = new List<Mahasiswa>
       {

        new Mahasiswa("Andry Nur Falah", 1302213005, c, 2021),
        new Mahasiswa("Reyhan Azani", 1302210110, c, 2021),
        new Mahasiswa("Rafa Eka", 1302210123, c, 2021),
        new Mahasiswa("Yosua WilliamPallunan", 1302210126, c, 2021),
        new Mahasiswa("Satrio Agul", 1302210065, c, 2021),
       };

        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return mahasiswaList;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return mahasiswaList[id];
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Mahasiswa newMahasiswa)
        {
            mahasiswaList.Add(newMahasiswa);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            mahasiswaList.RemoveAt(id);
        }
    }
}
