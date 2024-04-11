import React from "react";
import AppBar from "@mui/material/AppBar";
import Box from "@mui/material/Box";
import Toolbar from "@mui/material/Toolbar";
import Typography from "@mui/material/Typography";
import IconButton from "@mui/material/IconButton";
import { Link } from "react-router-dom";

function Header() {
  return (
    <Box sx={{ flexGrow: 1 }}>
      <AppBar position="static">
        <Toolbar variant="dense">
          <IconButton
            edge="start"
            color="inherit"
            aria-label="menu"
            sx={{ mr: 2 }}
          >
            CAT MASH
          </IconButton>
          <nav className="headerNav">
            <a href="/">
              <Typography variant="h6" color="inherit" component="div">
                Acceuil
              </Typography>
            </a>
            <a href="votes">
              <Typography variant="h6" color="inherit" component="div">
                Votes
              </Typography>
            </a>
          </nav>
        </Toolbar>
      </AppBar>
    </Box>
  );
}

export default Header;
