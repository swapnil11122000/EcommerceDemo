
using EProject.Data;
using EProject.Models;
namespace EProject.Models
{
    public class ProductDAL
    {
        private readonly ApplicationDbContext db;

        public ProductDAL(ApplicationDbContext db)
        {
            this.db = db;
        }

        public List<Product> GetAllProducts()
        {

            return db.products.ToList();
        }

        public Product GetProductById(int Id)
        {
            var result = db.products.Where(x => x.Pid == Id).FirstOrDefault();
            return result;
        }

        public int AddProduct(Product prod)
        {
            var result = 0;
            db.products.Add(prod);
            result = db.SaveChanges();
            return result;
        }

        public int UpdateProduct(Product prod)
        {
            int result = 0;
            var res = db.products.Where(x => x.Pid == prod.Pid).FirstOrDefault();
            if (res != null)
            {
                res.Pname = prod.Pname;
                res.Price = prod.Price;
                res.Catid= prod.Catid;
                res.Company= prod.Company;
                res.Description= prod.Description;
                res.Img= prod.Img;
                result = db.SaveChanges();
            }
            return result;
        }


        public int DeleteProduct(int Id)
        {
            int res = 0;
            var result = db.products.Where(x => x.Pid == Id).FirstOrDefault();
            if (result != null)
            {
                db.products.Remove(result);
                res = db.SaveChanges();
            }
            return res;
        }


    }


}
