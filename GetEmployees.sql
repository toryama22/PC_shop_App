SELECT Employees.Id, Employees.FIO, Employees.[Employee number], Employees.Male,
                             Employees.[Date of BirthDay], Employees.Passport, Employees.Adress,
                             Employees.Phone, Positions.Position, Employees.Salary
                             FROM Positions
                             INNER JOIN Employees ON Employees.Position = Positions.Id