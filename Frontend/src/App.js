import './App.css';
import { BrowserRouter as Router, Switch, Route } from "react-router-dom";
import React from "react";
import Navbar from "./components/Navbar";
import Books from "./components/Books";
import Categories from "./components/Categories";
import Authors from "./components/Authors";
import Publishers from "./components/Publishers";
import CardDetail from "./components/CardDetail";
import AuthorDetail from "./components/AuthorDetail";
import PublisherDetail from "./components/PublisherDetail";
import CategoryDetail from "./components/CategoryDetail";

function App() {
 
  return (
    <Router>
      <Navbar />     
      <br/>
      <div className="container">
      <div class="row">
        <div class="col-2">
          <Categories />
          <br/>
          <Authors />
          <br/>
          <Publishers />
          </div>
      <Switch>
      <div class="col-10">
        <Route exact path="/"> 
          <Books />
        </Route>   
        
        <Route path='/books/:id' component={CardDetail}/>
        <Route path='/authors/:id' component={AuthorDetail}/>
        <Route path='/publishers/:id' component={PublisherDetail}/>
        <Route path='/categories/:id' component={CategoryDetail}/>
        </div>
      </Switch>
      </div>
      </div>
    
  </Router>
  );
}

export default App;
