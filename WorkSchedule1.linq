<Query Kind="Expression">
  <Connection>
    <ID>cedb5cf0-7e01-49d9-bb22-6ed768a7688a</ID>
    <Server>.</Server>
    <Database>WorkSchedule</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

// Show all skills requiring a ticket and which employees have those skills. Include all the data as seen in the following image.
from items in Skills
where items.RequiresTicket == true
select items // create anonymous type [employeeSkills] with another anon for relevant info