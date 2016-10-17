<Query Kind="Expression">
  <Connection>
    <ID>1ca4c2aa-2d76-4fd3-81eb-94d8b91ffbc4</ID>
    <Server>.</Server>
    <Database>WorkSchedule</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

// List all the skills for which we do not have any qualfied employees. [count of employeeID for skill == 0]
from item in Skills
where item.EmployeeSkills.Count() == 0
select item.Description