import Header from './header/Header'
import { Routes, Route } from 'react-router-dom'
import Footer from './footer/Footer'
import Home from './home/Home'
import styles from './app.module.css'
import Menu from './menu/Menu'
import Contacts from './contacts/Contacts'
import VacanciesCard from './vacansies/vacanсies_cards/VacanciesCard'

const App = () => {
    return (
        <div className={styles.container}>
            <Header />
            <div className={styles.content}>
                <div>
                    <Routes>
                        <Route path="" element={<Home />} />
                        <Route path="menu/*" element={<Menu />} />
                        <Route path="contacts" element={<Contacts />} />
                        <Route path="job" element={<VacanciesCard />} />
                        <Route path="*" element={<p>page not found</p>} />
                    </Routes>
                </div>

                <Footer />
            </div>
        </div>
    )
}

export default App
