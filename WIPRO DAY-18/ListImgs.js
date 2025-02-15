import { useState } from "react";
import Img1 from './images/1.png';
import Img2 from './images/2.jpg';
import Img3 from './images/3.jpg';
import Img4 from './images/4.jpg';
import Img5 from './images/5.jpg';



export default function ListImages(){
    const [showlist,setImgs] =useState(false)

    const images = [Img1,Img2,Img3,Img4,Img5]
    
    return(
    <div>
        <button onClick={()=>setImgs(!showlist)}>
            {showlist? 'Images are displayed' : 'No images in the list'}
        </button>
        {showlist && (
            <ul>
                {images.map(item=>
                <li><img src={item} style={{ width: '200px', height: 'auto' }}/> </li> )}
            </ul>
        )}
    </div>

    )
}

