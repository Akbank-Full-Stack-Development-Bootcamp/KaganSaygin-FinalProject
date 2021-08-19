import React, { useState, useEffect } from 'react'
import {Link} from 'react-router-dom'
import CardList from "./CardList";

function CategoryDetail(props) {

    const[category, setcategory] = useState({
        category:{}
    })

    const[books,setbooks] = useState([])
    
    useEffect(() => {
        const getcategory = () => {
            fetch(`https://localhost:44363/api/categories/${props.match.params.id}`)
              .then((response) => response.json())
              .then(json => setcategory(json))
        }



        const getBooks = () => {
            fetch(`https://localhost:44363/api/Books/GetByCategoryBooks/${props.match.params.id}`)
              .then((response) => response.json())
              .then(json => setbooks(json))
        }
        
        getcategory()
        getBooks()
    },[props.match.params.id])

return (

<div className="container">
<div className="alert alert-success" role="alert">
  <h4 className="text-center"><strong>{category.name}</strong> Kategorisindeki Kitaplar</h4>
</div>
<hr/>
<div className="border border-3 border-success p-2"><CardList books={books} /></div>

</div>
)

}

export default CategoryDetail