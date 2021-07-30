using PhoneBookMVC.Models;
using PhoneBookMVC.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBookMVC.Helpers
{
    public class ContactHelper
    {
        public async Task<Contact> GetImage(Contact contact, IImageService imageService)
        {
            if (contact.ImageFile != null)
            {
                contact.ImageData = await imageService.ConvertFileToByteArrayAsync(contact.ImageFile);
                contact.ImageType = contact.ImageFile.ContentType;
                return contact;
            }
            return contact;
        }
        
    }
}
