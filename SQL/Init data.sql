insert into dbo.Product(Name) values
('Product 1'),
('Product 2 without category'),
('Product 3'),
('Product 4');

insert into dbo.Category(Name) values
('Category 1'),
('Category 2'),
('Category 3'),
('Category 4'),
('Category 5');

insert into dbo.ProductCategory(ProductId, CategoryId) values
(1, 1),
(1, 2),
(1, 3),
(1, 4),
(1, 5),
(3, 3),
(3, 4),
(4, 2),
(4, 5);