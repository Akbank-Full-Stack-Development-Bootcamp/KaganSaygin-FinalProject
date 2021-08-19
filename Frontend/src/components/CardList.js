import React, { } from "react";
import Card from "./Card";

const CardList = (props) => {
  
    return (
      <div className="row">

        {
          props.books.map(function(book){
            return(
              <div className="col-3" key={book.id}>
                  <Card book={book}/>
              </div>
            )
          })
        }
        
      </div>
    );
  
}

export default CardList;