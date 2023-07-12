using DesignPatterns.Models;
using System.Collections;
using System.Collections.Generic;

namespace DesignPatterns.Infraestructure.Singleton
{
    public class MemoryCollection
    {
        public ICollection<Vehicle> Vehiculos { get; set; }

        private static MemoryCollection _instance;

        // Agregamos un objeto de bloqueo para garantizar la exclusión mutua al crear la instancia
        private static readonly object _lock = new object();

        private MemoryCollection()
        {
            Vehiculos = new List<Vehicle>();
        }

        public static MemoryCollection GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new MemoryCollection();
                    }
                }
            }

            return _instance;
        }
    }
}
