# DiplimUI
Diplim_ui
Version unity - 2021.3.11f1

 if (Input.GetMouseButtonDown(0))
 
        {
            Vector3 ray = Camera.main.ScreenToWorldPoint(Input.mousePosition);       
            Instantiate(particle, ray, transform.rotation);      
        }
