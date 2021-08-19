import React, { useState, useEffect } from 'react'
import {Link} from 'react-router-dom'
import CardList from "./CardList";

function AuthorDetail(props) {

    const[author, setauthor] = useState({
        author:{}
    })

    const[books,setbooks] = useState([])
    
    useEffect(() => {
        const getAuthor = () => {
            fetch(`https://localhost:44363/api/authors/${props.match.params.id}`)
              .then((response) => response.json())
              .then(json => setauthor(json))
        }
        



        const getBooks = () => {
            fetch(`https://localhost:44363/api/Books/GetByAuthorBooks/${props.match.params.id}`)
              .then((response) => response.json())
              .then(json => setbooks(json))
        }
        
        getAuthor()
        getBooks()
    },[props.match.params.id])

return (


<div className="card border border-primary border border-5">                
<div className="card-body row">
    
<div className="col-md-3">
<h1 className="card-title fw-bolder text-center text-primary"><strong>{author.firstName} {author.lastName}</strong></h1>
<img src={author.image} className="img-fluid img-thumbnail" loading="lazy"/>

</div>
<div className="col-md-9">
<p className="card-text">{author.description}</p></div>
<hr/>
<div className="alert alert-secondary" role="alert">
  <h5 className="fst-italic">{author.firstName} {author.lastName} Kitapları</h5>
</div>
<CardList books={books} />
</div>
</div>



)



}

export default AuthorDetail