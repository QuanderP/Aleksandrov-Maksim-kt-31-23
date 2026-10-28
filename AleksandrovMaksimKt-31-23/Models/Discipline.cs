using System.Diagnostics;




namespace AleksandrovMaksimKt_31_23.Models
{

    /// <summary>
    /// Доменная модель учебной дисциплины
    /// </summary>
    public class Discipline
    {

        /// <summary>Идентификатор дисциплины</summary>
        public int DisciplineId { get; set; }

        /// <summary>Наименование дисциплины</summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>Признак логического удаления записи</summary>
        public bool IsDeleted { get; set; }

        // Навигационное свойство: у дисциплины много оценок
        /// <summary>Коллекция оценок по данной дисциплине</summary>
        public ICollection<Grade> Grades { get; set; } = new List<Grade>();

    }

}
