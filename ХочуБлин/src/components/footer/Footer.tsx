import { memo } from 'react'
import styles from './footer.module.css'
import { Link } from 'react-router-dom'

const Footer = () => {
    const prev = () => scrollTo({ top: 0 })
    return (
        <footer className={styles.footer}>
            <div className={styles.content}>
                <div className={styles.logo}>
                    <img src="/footer_logo.png" alt="" />
                </div>
                <div className={styles.social_media}>
                    <a target="_blank" href="https://vk.com">
                        <img src="/footer_vk.png" alt="" />
                    </a>
                    <a target="_blank" href="https://www.instagram.com/">
                        <img src="/footer_insta.png" alt="" />
                    </a>
                    <a target="_blank" href="https://desktop.telegram.org/?setln=en">
                        <img src="/footer_tg.png" alt="" />
                    </a>
                </div>
                <div className={`${styles.l1} ${styles.link}`}>
                    <Link to={'/contacts'} onClick={prev} className={styles.react_link}>
                        Контакты
                    </Link>
                </div>
                <div className={`${styles.l2} ${styles.link}`}>
                    <a href="" className={styles.react_link}>
                        Адрес
                    </a>
                </div>
                <div className={`${styles.l3} ${styles.link}`}>
                    <Link to={'/menu'} onClick={prev} className={styles.react_link}>
                        Меню
                    </Link>
                </div>
                <div className={`${styles.l4} ${styles.link}`}>
                    <Link to={'/job'} onClick={prev} className={styles.react_link}>
                        Вакансии
                    </Link>
                </div>
                <div className={`${styles.l5} ${styles.link}`}>
                    <a href="" className={styles.react_link}>
                        Отзывы
                    </a>
                </div>
                <div className={`${styles.l6} ${styles.link}`}>
                    <Link to={'/job'} onClick={prev} className={styles.react_link}>
                        Вакансии
                    </Link>
                </div>{' '}
                <div className={`${styles.l7} ${styles.link} ${styles.active}`}>
                    <Link to={'/'} onClick={prev} className={styles.react_link}>
                        Главная
                    </Link>
                </div>
            </div>
            <div className={styles.icon}>
                <img src="/footer_star.svg" alt="" />
            </div>
        </footer>
    )
}
export default memo(Footer)
