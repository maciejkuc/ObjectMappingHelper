﻿using System.Collections.Generic;


namespace ObjectMappingHelper.Interfaces
{
    public interface IObjectProvider
    {
        IEnumerable<IObjectInfo> Properties { get; set; }

        /// <summary>
        /// Zwraca kolekcję właściwości
        /// </summary>
        IEnumerable<IObjectInfo> GetProperties();

        /// <summary>
        /// Pobiera poprzez reflectionHelpera właściwości z obiektu i zapisuje do kolekcji
        /// </summary>
        IEnumerable<IObjectInfo> GetPropertiesFrom<T>();
    }
}
