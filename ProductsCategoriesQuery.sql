SELECT Products.name, Categories.name
FROM Products 
    LEFT JOIN ProductsCategories ON Products.id = ProductsCategories.ProductId 
    LEFT JOIN Categories ON ProductsCategories.CategoryId = Categories.Id;