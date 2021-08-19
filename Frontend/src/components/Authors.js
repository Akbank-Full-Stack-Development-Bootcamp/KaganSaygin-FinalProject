import React, { useState, useEffect } from 'react'
import {Link} from 'react-router-dom'
function Authors() {

    const [authors, setauthors] = useState([])
    const [loading, setLoading] = useState(false)
    

    useEffect(() => {
        getauthors()
    },[])

    const getauthors = () => {
        setLoading(true)
        fetch("https://localhost:44363/api/authors")
          .then((response) => response.json())
          .then(json => {
              setauthors(json)
              setLoading(false)})
    }
        return (

          <div className="card border-primary" >
<div className="card-header text-primary">
    Yazarlar
  </div>
           
          <ul className="list-group">
           
              
              {loading ? (
                <div className="d-flex justify-content-center">
                  <div className="spinner-border text-warning" role="status">
                    <span className="visually-hidden">Loading...</span>
                  </div>
                </div>
              ) : (

                authors.map(function(authors){
                  return(  
                  <Link to = {'/authors/'+authors.id}><li className="list-group-item">{authors.firstName} {authors.lastName}</li></Link>
                  )
                })
              )}
            
          </ul>
        </div>
 )
}

export default Authors