import React, { useState, useEffect } from 'react'
import {Link} from 'react-router-dom'

function CardDetail(props) {

    const[book, setBook] = useState({
        book:{}
    })
    
    useEffect(() => {

        const getBook = () => {
            fetch(`https://localhost:44363/api/books/${props.match.params.id}`)
              .then((response) => response.json())
              .then(json => setBook(json))
        }
        getBook()
    },[props.match.params.id])
    
    
    return (
<div className="row" >
<div className="col-md-3">
<img src={book.coverImage} height="449" width="260" className="img-fluid img-thumbnail border border-dark border-2" loading="lazy"/>
</div>
  <div className="card border border-dark border-2 col-md-9">                
  <div className="card-body">
  
    <h1 className="card-title fw-bolder"><strong>{book.name}</strong></h1>
    <hr/>
    <Link to = {'/authors/' + book.authorId}><h5 className="card-subtitle mb-2 link-primary">{book.author}</h5></Link>     
    <Link to = {'/publishers/'+ book.publisherId}><h6 className="card-subtitle mb-2 link-secondary">{book.publisher}</h6></Link> 
    <Link to = {'/categories/'+ book.categoryId}><span class="badge rounded-pill bg-success">{book.category}</span></Link> 
    
    <p className="card-text font-monospace">{book.description}</p>
    
    <button type="button" class="btn btn-outline-primary btn-lg">{book.price} TL</button>

  </div>
</div>
</div>        
       
    )
}

export default CardDetail