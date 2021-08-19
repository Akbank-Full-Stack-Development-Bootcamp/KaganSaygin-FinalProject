import React, { useState, useEffect } from 'react'
import {Link} from 'react-router-dom'
import CardList from "./CardList";

function PublisherDetail(props) {

    const[publisher, setpublisher] = useState({
        publisher:{}
    })

    const[books,setbooks] = useState([])
    
    useEffect(() => {
        const getPublisher = () => {
            fetch(`https://localhost:44363/api/publishers/${props.match.params.id}`)
              .then((response) => response.json())
              .then(json => setpublisher(json))
        }
        



        const getBooks = () => {
            fetch(`https://localhost:44363/api/Books/GetByPublisherBooks/${props.match.params.id}`)
              .then((response) => response.json())
              .then(json => setbooks(json))
        }
        
        getPublisher()
        getBooks()
    },[props.match.params.id])

return (

<div className="container">
<div className="alert alert-info" role="alert">
  <h4 className="fw-bolder text-center"><strong>{publisher.name}</strong> <em>Yayınevi Kitapları</em></h4>
</div>
<hr/>
<div className="border border-3 border-info p-2">
<CardList books={books} />
</div>
</div>
)



}

export default PublisherDetail