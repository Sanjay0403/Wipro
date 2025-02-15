import Book from "./Book"
import React,{ useState } from "react"
import BookItem from "./BookDetails";

export const BookList = () => {

    //List of books initialized using usestate hook
    const [lstbooks] = useState([
        new Book("The Avenger","Stan Lee","Sci-Fi"),
        new Book("The Room","Arthur Martin","horror"),
        new Book("The Royale","Lee Chon","Gaming")
    ])

    const [showDetils,setShowDetails] = useState(Array(lstbooks.length).fill(false));

    const toggleDetails = (index) =>{
        const updatedetails = [...showDetils];
        updatedetails[index]=!updatedetails[index];
        setShowDetails(updatedetails)
    };
    
     return (
        <div>
        <h1>BookList</h1>
                  {lstbooks.map((item,index) => (
                    <BookItem key={index} item={item} index={index} showDetails={showDetils[index]} toggleDetails={toggleDetails}></BookItem>))}
       </div>
    )
}