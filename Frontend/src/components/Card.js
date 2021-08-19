import React, {  } from 'react'
import {Link} from 'react-router-dom'
const Card = (props) => {
    
      const{id, name,price, coverImage,author,publisher,authorId,publisherId } = props.book
      
        return (
         
            <div className="card text-center"> 
            <Link to = {'/books/'+id} ><img className="card-img-top img-fluid"  src={coverImage} alt={name}/> </Link>  

            <div className="card-body">
            <Link to = {'/books/'+id} className="btn btn-light b"><h4 className="card-title">{name}</h4> </Link>
            <Link to = {'/authors/'+authorId}><h6 className="card-subtitle mb-2 text-primary">{author}</h6></Link>            
            <Link to = {'/publishers/'+publisherId}><p className="card-text text-muted">{publisher}</p></Link>
            <h3><span className="badge bg-secondary">{price} TL</span></h3>
            </div>
           
          </div>
        )    
}

export default Card