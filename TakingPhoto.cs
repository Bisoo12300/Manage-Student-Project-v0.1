using System;
using System.Drawing;
using System.Drawing.Imaging;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Imaging.Filters;
using System.IO;

namespace TakingPhoto

{
    class Camera
    {
        static VideoCaptureDevice cam;
        static Bitmap image;

        public static Bitmap TakePhoto()
        {
            FilterInfoCollection webcamList = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (webcamList.Count == 0)
            {
                Console.WriteLine("No cameras found.");
                return null;
            }

            cam = new VideoCaptureDevice(webcamList[1].MonikerString);
            cam.NewFrame += Cam_NewFrame;
            cam.Start();

            while (image == null) ; // Wait for camera to initialize

            cam.SignalToStop();
            cam.WaitForStop();

            int i = 1;
            string folderPath = @"F:\QLSV\Face";
            string filePath = folderPath + "photo" + i + ".jpg";
            while (File.Exists(filePath))
            {
                i++;
                filePath = folderPath + "photo" + i + ".jpg";
            }

            image.Save(filePath, ImageFormat.Jpeg);
            Console.WriteLine("Photo saved at " + filePath);

            return image;
        }

        private static void Cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            image = (Bitmap)eventArgs.Frame.Clone();
        }

    }
}
