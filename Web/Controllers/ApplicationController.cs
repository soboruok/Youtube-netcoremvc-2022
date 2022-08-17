using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Web.Data;
using Web.Models;
using Web.ViewModels;

namespace Web.Controllers
{

    public class ApplicationController : Controller
    {
        private readonly IWebHostEnvironment _iweb;
        private readonly WebDbContext _db;

        public ApplicationController(IWebHostEnvironment iweb, WebDbContext db)
        {
            _iweb = iweb;
            _db = db; 

        }
        
        //
        public IActionResult Index()
        {
            ViewBag.title = "지원하기";
            return View(new ApplicationUserViewModel() { Regdate = DateTime.Now});
        }

        [HttpPost]
        public IActionResult Index(ApplicationUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniquteFileName = UploadedFile(model);
                ApplicationUser newUser = new ApplicationUser
                {
                    UserName = model.UserName,
                    UserPhone = model.UserPhone,
                    UserCareer = model.UserCareer,
                    Useraddress = model.Useraddress,
                    UserCV = uniquteFileName,
                    Regdate = model.Regdate
                };
                _db.ApplicationUsers.Add(newUser);

                //결과가 성공적이라면, 
                if(_db.SaveChanges() > 0)
                {
                    return RedirectToAction("Index", "Application"); 
                } else
                {
                    ModelState.AddModelError(string.Empty, "다시 입력해주세요"); 
                }
            }
            return View(model); 
        }

        public IActionResult Edit(int Id)
        {
            //UserName UserPhone UserCareer Useraddress UserCV Regdate
            ApplicationUser model = _db.ApplicationUsers.Find(Id);
            ApplicationUserEditModel applicationUserEditModel = new ApplicationUserEditModel
            {
                UserName = model.UserName,
                UserPhone = model.UserPhone,
                UserCareer = model.UserCareer,
                Useraddress = model.Useraddress,
                ExistingCV = model.UserCV
            };
            return View(applicationUserEditModel); 
        }

        [HttpPost]
        public IActionResult Edit(ApplicationUserEditModel model, int Id)
        {
            if (ModelState.IsValid)
            {
                //UserName UserPhone UserCareer Useraddress UserCV 
                ApplicationUser ApplicationUser = _db.ApplicationUsers.Find(Id);
                ApplicationUser.UserName = model.UserName;
                ApplicationUser.UserPhone = model.UserPhone;
                ApplicationUser.UserCareer = model.UserCareer;
                ApplicationUser.Useraddress = model.Useraddress;


                //첨부파일이 있다면, 
                if (model.UserCV != null)
                {
                    //근데 그첨부파일이 기존에 저장된 파일이면, 그거 삭제한다. 
                    if (model.ExistingCV != null)
                    {
                        string filePath = Path.Combine(_iweb.WebRootPath, "upload", model.ExistingCV);
                        System.IO.File.Delete(filePath);
                    }
                    ApplicationUser.UserCV = UploadedFile(model);
                }

                _db.Entry(ApplicationUser).State = EntityState.Modified;
                _db.SaveChanges(); 
            }
                return View(); 
        }


        //글 모두 불러오기
        public IActionResult List()
        {
            //select * from ApplicationUser
            var applicationList = from A in _db.ApplicationUsers select A;
            return View(applicationList); 

        }

        //글 읽어오기
        public IActionResult Detail(int ID)
        {
            var detailID = _db.ApplicationUsers.FirstOrDefault(c => c.UserId.Equals(ID)); 
            return View(detailID);
        }

        private string UploadedFile(ApplicationUserViewModel model)
        {
            string uniqueFileName = null;

            if (model.UserCV != null)
            {
                //첨부파일이 들어갈 경로를 만들어준다. WebRootPath + /upload합쳐준다. 
                string uploadsFolder = Path.Combine(_iweb.WebRootPath + "/upload");
                //GUID를 사용해서 고유한이름생성
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.UserCV.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                //파일 업로드를 위해서 FileStream을사용한다. 
                model.UserCV.CopyTo(new FileStream(filePath, FileMode.Create));
            }

            return uniqueFileName;
        }
    }
}
