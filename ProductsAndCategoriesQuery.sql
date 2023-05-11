select p.Name, c.Name
from Products p
left join Products_Categories pc on p.ProductId = pc.ProductId /*Left Join. По какой-то причине в тестовой базе данных сработало и с Inner Join'ом, но, попробовав на другом примере, Left Join оказался правильным выбором.*/
left join Categories c on c.CategoryId = pc.CategoryId;
