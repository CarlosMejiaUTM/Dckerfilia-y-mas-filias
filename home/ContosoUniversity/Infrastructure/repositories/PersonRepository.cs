using ContosoUniversity.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;

public class PersonRepository
{
    private DBLocalContosoUniversity _dbContext;

    public PersonRepository()
    {
        _dbContext = new DBLocalContosoUniversity();
    }

    public IEnumerable<Person> Get()
    {
        return _dbContext.Persons;
    }

    public Person Get(int id)
    {
        return _dbContext.Persons.FirstOrDefault(person => person.Id == id)
               ?? new Person();
    }

    public IEnumerable<Person> Get(Person person)
    {
        var query = _dbContext.Persons.Select(p => p);

        if (person.Id > 0)
            query = query.Where(p => p.Id == person.Id);

        if (!string.IsNullOrEmpty(person.FirstName))
            query = query.Where(p => p.FirstName.Contains(person.FirstName));

        if (!string.IsNullOrEmpty(person.LastName))
            query = query.Where(p => p.LastName.Contains(person.LastName));

        if (person.HireDate != DateTime.MinValue)
            query = query.Where(p => p.HireDate == person.HireDate);

        if (person.EnrollmentDate != DateTime.MinValue)
            query = query.Where(p => p.EnrollmentDate == person.EnrollmentDate);

        if (!string.IsNullOrEmpty(person.Address))
            query = query.Where(p => p.Address != null && p.Address.Contains(person.Address));

        if (person.HasParkingLot.HasValue)
            query = query.Where(p => p.HasParkingLot == person.HasParkingLot);

        return query.ToList();
    }

    // Aquí puedes agregar métodos para manipular los datos de la base de datos.
}
