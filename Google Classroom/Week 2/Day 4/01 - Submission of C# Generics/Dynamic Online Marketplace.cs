using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_2.Day_4._01___Submission_of_C__Generics
{
    internal class Dynamic_Online_Marketplace
    {
        public static void Main(string[] args)
        {
            BookCategory fiction = new BookCategory("Fiction Books", "Mystery");
            Product<BookCategory> book1 = new Product<BookCategory>("The Silent Patient", 14.99, fiction);
            book1.DisplayProduct();

            ClothingCategory mensWear = new ClothingCategory("Men's Clothing", "Large");
            Product<ClothingCategory> shirt = new Product<ClothingCategory>("Cotton T-Shirt", 24.99, mensWear);
            shirt.DisplayProduct();

            ApplyDiscount(book1, 15);
            ApplyDiscount(shirt, 20);

            List<Product<BookCategory>> bookCatalog = new List<Product<BookCategory>>();
            bookCatalog.Add(book1);
            bookCatalog.Add(new Product<BookCategory>("Gone Girl", 12.99, fiction));

            Console.WriteLine($"\nBook Catalog ({bookCatalog.Count} books):");
            foreach(Product<BookCategory> book in bookCatalog)
            {
                book.DisplayProduct();
            }
        }

        public static void ApplyDiscount<T>(Product<T> product, double percentage) where T : Category
        {
            double discountAmount = product.price * (percentage / 100);
            double newPrice = product.price - discountAmount;
            Console.WriteLine($"\n{percentage}% discount on {product.productName}: ${product.price} -> ${newPrice}");
        }
    }
    public abstract class Category
    {
        public string categoryName;

        public Category(string categoryName)
        {
            this.categoryName = categoryName;
        }

        public abstract void ShowCategory();
    }

    public class BookCategory : Category
    {
        public string genre;

        public BookCategory(string categoryName, string genre) : base(categoryName)
        {
            this.genre = genre;
        }

        public override void ShowCategory()
        {
            Console.WriteLine($"Book Category: {categoryName}, Genre: {genre}");
        }
    }

    public class ClothingCategory : Category
    {
        public string size;

        public ClothingCategory(string categoryName, string size) : base(categoryName)
        {
            this.size = size;
        }

        public override void ShowCategory()
        {
            Console.WriteLine($"Clothing Category: {categoryName}, Size: {size}");
        }
    }

    public class Product<T> where T : Category
    {
        public string productName;
        public double price;
        public T productCategory;

        public Product(string productName, double price, T productCategory)
        {
            this.productName = productName;
            this.price = price;
            this.productCategory = productCategory;
        }

        public void DisplayProduct()
        {
            Console.WriteLine($"\nProduct: {productName}, Price: ${price}");
            productCategory.ShowCategory();
        }
    }
}
