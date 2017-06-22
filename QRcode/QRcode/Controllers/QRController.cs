using MessagingToolkit.QRCode.Codec; // you must to install this library in nuget console
using QRcode.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QRcode.Controllers
{
    public class QRController : Controller
    {
        // GET: QR
        public ActionResult Index()
        {
            return View();
        }

        // GET: QR/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: QR/Create
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult CodeCreation(QRmodel objectQR)
        {
            //We first declare the library
            QRCodeEncoder encoder = new QRCodeEncoder();
            encoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.H; // 30%
            //Make the scale
            encoder.QRCodeScale = 4;
            //Make the bitmap image with your URL, that we take from input and the we save in the QRmodel
            Bitmap img = encoder.Encode(objectQR.URL);
           
            ImageConverter converter = new ImageConverter();
            //Now we are going to convert   the image in byte
            //and then we are going to save the byte image in other attribute of QRmodel
            objectQR.codeQr = (byte[])converter.ConvertTo(img, typeof(byte[]));

            return View("Index",objectQR);
        }

        // POST: QR/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: QR/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: QR/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: QR/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: QR/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
