import CardsGrid from './cards-grid/CardsGrid'
import styles from './menu.module.css'
const Menu = () => {
    return (
        <div className={styles.wrapper}>
            <div className={styles.content}>
                <CardsGrid />
            </div>
        </div>
    )
}
export default Menu
