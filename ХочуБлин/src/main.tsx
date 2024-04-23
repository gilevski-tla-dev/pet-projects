import React from 'react'
import ReactDOM from 'react-dom/client'
import App from './components/App'
import './animation.module.css'
import './style.css'
import { BrowserRouter } from 'react-router-dom'
import { ThemeProvider } from 'src/provider/ThemeProvider'
import { ScrollProvider } from 'src/provider/ScrollProvider'

ReactDOM.createRoot(document.getElementById('root')!).render(
    <React.StrictMode>
        <BrowserRouter>
            <ThemeProvider>
                <ScrollProvider>
                    <App />
                </ScrollProvider>
            </ThemeProvider>
        </BrowserRouter>
    </React.StrictMode>
)
